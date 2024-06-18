using Lab5.CoreBusinessRules.Models.Results;

namespace Lab5.CoreBusinessRules.Services.Repositories;

public interface IAccountHistoryRepository
{
    IAsyncEnumerable<Result> FindHistoryByIdAsync(int id);
    Task AddOperationToHistoryAsync(Result result);
    IAsyncEnumerable<Result> GetFullHistoryAsync();
}