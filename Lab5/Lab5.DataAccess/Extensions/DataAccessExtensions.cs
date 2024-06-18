using FluentMigrator.Runner;
using Lab5.CoreBusinessRules.Services.Repositories;
using Lab5.DataAccess.Migrations;
using Lab5.DataAccess.Services.DataBaseConnectionHandler;
using Lab5.DataAccess.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5.DataAccess.Extensions;

public static class DataAccessExtensions
{
    public static IServiceCollection GetDataAccessServices(this IServiceCollection collection, string connection)
    {
        collection.AddSingleton<ConnectionHandler>(connectionHandler => new ConnectionHandler(connection));
        collection.AddScoped<IAccountHistoryRepository, AccountHistoryRepository>();
        collection.AddScoped<IBankAccountRepository, BankAccountRepository>();
        collection.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
                .AddPostgres()
                .WithGlobalConnectionString(connection)
                .ScanIn(typeof(CreateTablesMigration).Assembly).For.Migrations()
                .ScanIn(typeof(DefaultUserAddMigration).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .BuildServiceProvider(false);

        return collection;
    }
}