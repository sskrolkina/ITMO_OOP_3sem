#pragma warning disable CA2007
using Lab5.CoreBusinessRules.Entities;
using Lab5.CoreBusinessRules.Models.Results.LoginResults;
using Lab5.CoreBusinessRules.Services.Repositories;

namespace Lab5.CoreBusinessRules.Services;

public class TerminalLogin
{
    private readonly IBankAccountRepository _bankAccountRepository;

    public TerminalLogin(IBankAccountRepository bankAccountRepository)
    {
        _bankAccountRepository = bankAccountRepository;
    }

    public async Task<LoginResult> LoginAsync(int id, int password)
    {
        Account? account = await _bankAccountRepository.FindAccountByIdAsync(id);
        if (account is null)
        {
            return new NoAccount(account);
        }

        if (account.Password != password)
        {
            return new WrongPassword(account);
        }

        return new LoginSuccess(account);
    }
}