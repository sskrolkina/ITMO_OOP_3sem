#pragma warning disable CA2007
using Lab5.CoreBusinessRules.Entities;
using Lab5.CoreBusinessRules.Models;
using Lab5.CoreBusinessRules.Services.Repositories;
using Lab5.DataAccess.Services.DataBaseConnectionHandler;
using Npgsql;

namespace Lab5.DataAccess.Services.Repositories;

public class BankAccountRepository : IBankAccountRepository
{
    private readonly ConnectionHandler _connectionHandler;

    public BankAccountRepository(ConnectionHandler connectionHandler)
    {
        _connectionHandler = connectionHandler;
    }

    public async Task<Account?> FindAccountByIdAsync(int id)
    {
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand("select * from bank where id=@id");
        command.Parameters.AddWithValue("id", id);
        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();
        await reader.ReadAsync();
        return new Account(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), new Role(reader.GetString(4)));
    }

    public async IAsyncEnumerable<Account> GetAccountsListAsync()
    {
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand("select * from bank");

        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            yield return new Account(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), new Role(reader.GetString(4)));
        }
    }

    public async Task UpdateAsync(Account account)
    {
        ArgumentNullException.ThrowIfNull(account);
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand($"update bank " +
                                                                            $"set password='{account.Password}'," +
                                                                            $"balance='{account.Balance}' " +
                                                                            $"where id='{account.Id}'");
        await command.ExecuteNonQueryAsync();
    }

    public async Task Add(Account account)
    {
        ArgumentNullException.ThrowIfNull(account);
        NpgsqlCommand command =
            _connectionHandler.DataSource.CreateCommand("insert into bank (id,name,balance,password,role) values (@id,@name,@balance,@password,@role)");
        command.Parameters.AddWithValue("id", account.Id);
        command.Parameters.AddWithValue("name", account.Name);
        command.Parameters.AddWithValue("balance", account.Balance);
        command.Parameters.AddWithValue("password", account.Password);
        command.Parameters.AddWithValue("role", account.Role.RoleType);
        await command.ExecuteNonQueryAsync();
    }
}