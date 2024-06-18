#pragma warning disable CA2007
using Lab5.CoreBusinessRules.Entities;
using Lab5.CoreBusinessRules.Models.Results;
using Lab5.CoreBusinessRules.Services.Repositories;

namespace Lab5.CoreBusinessRules.Services.UseScenarios.Implementations;

public class AdminUseScenario : IAdminUseScenario
{
    private readonly IBankAccountRepository _bankAccountRepository;
    private readonly IAccountHistoryRepository _accountHistoryRepository;

    public AdminUseScenario(IBankAccountRepository bankAccountRepository, IAccountHistoryRepository accountHistoryRepository)
    {
        _bankAccountRepository = bankAccountRepository;
        _accountHistoryRepository = accountHistoryRepository;
    }

    public IAsyncEnumerable<Result> GetFullAccountsHistoryAsync()
    {
        return _accountHistoryRepository.GetFullHistoryAsync();
    }

    public IAsyncEnumerable<Account> GetBankAccountsListAsync()
    {
        return _bankAccountRepository.GetAccountsListAsync();
    }

    public async Task ChangePasswordAsync(Account account, int password)
    {
        ArgumentNullException.ThrowIfNull(account);
        account.Password = password;
        await _bankAccountRepository.UpdateAsync(account);
    }

    public async Task AddAccount(Account account)
    {
        ArgumentNullException.ThrowIfNull(account);
        await _bankAccountRepository.Add(account);
    }
}