using Lab5.CoreBusinessRules.Entities;

namespace Lab5.CoreBusinessRules.Models.Results.LoginResults;

public record NoAccount : LoginResult
{
    public NoAccount(Account? account)
        : base(account) { }
}