using Lab5.CoreBusinessRules.Entities;

namespace Lab5.CoreBusinessRules.Models.Results.LoginResults;

public record LoginSuccess : LoginResult
{
    public LoginSuccess(Account account)
        : base(account) { }
}