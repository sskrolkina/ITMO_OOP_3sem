using Lab5.CoreBusinessRules.Entities;

namespace Lab5.CoreBusinessRules.Services.Repositories;

public interface IBankAccountRepository
{
    Task<Account?> FindAccountByIdAsync(int id);
    IAsyncEnumerable<Account> GetAccountsListAsync();
    Task UpdateAsync(Account account);
    Task Add(Account account);
}