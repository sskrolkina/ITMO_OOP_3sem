#pragma warning disable CA2007
using Lab5.CoreBusinessRules.Models.Results;
using Lab5.CoreBusinessRules.Services.Repositories;
using Lab5.DataAccess.Services.DataBaseConnectionHandler;
using Npgsql;

namespace Lab5.DataAccess.Services.Repositories;

public class AccountHistoryRepository : IAccountHistoryRepository
{
    private readonly ConnectionHandler _connectionHandler;

    public AccountHistoryRepository(ConnectionHandler connectionHandler)
    {
        _connectionHandler = connectionHandler;
    }

    public async IAsyncEnumerable<Result> FindHistoryByIdAsync(int id)
    {
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand("select * from history where id=@id");
        command.Parameters.AddWithValue("id", id);
        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            yield return new Result(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3));
        }
    }

    public async Task AddOperationToHistoryAsync(Result result)
    {
        ArgumentNullException.ThrowIfNull(result);
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand(
            "insert into history (id, operationtype, balance, message) VALUES (@id, @operationtype, @balance, @message)");
        command.Parameters.AddWithValue("id", result.Id);
        command.Parameters.AddWithValue("operationtype", result.OperationType);
        command.Parameters.AddWithValue("balance", result.Balance);
        command.Parameters.AddWithValue("message", result.Message);

        await command.ExecuteNonQueryAsync();
    }

    public async IAsyncEnumerable<Result> GetFullHistoryAsync()
    {
        NpgsqlCommand command = _connectionHandler.DataSource.CreateCommand("select * from history");

        await using NpgsqlDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            yield return new Result(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3));
        }
    }
}