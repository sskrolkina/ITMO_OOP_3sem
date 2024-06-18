using Lab5.CoreBusinessRules.Entities;
using Lab5.CoreBusinessRules.Models.Results;

namespace Lab5.CoreBusinessRules.Services.UseScenarios;

public interface IUserUseScenario
{
    Task<Result> RefillAsync(double amount, Account account);
    Task<Result> WithdrawAsync(double amount, Account account);
    IAsyncEnumerable<Result> AccountHistoryAsync(int id);
}