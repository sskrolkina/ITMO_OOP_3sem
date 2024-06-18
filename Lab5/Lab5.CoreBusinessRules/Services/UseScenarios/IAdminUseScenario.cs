using Lab5.CoreBusinessRules.Entities;
using Lab5.CoreBusinessRules.Models.Results;

namespace Lab5.CoreBusinessRules.Services.UseScenarios;

public interface IAdminUseScenario
{
    IAsyncEnumerable<Result> GetFullAccountsHistoryAsync();
    IAsyncEnumerable<Account> GetBankAccountsListAsync();
    Task ChangePasswordAsync(Account account, int password);
    Task AddAccount(Account account);
}