using Lab5.CoreBusinessRules.Entities;

namespace Lab5.CoreBusinessRules.Models.Results.LoginResults;

public record WrongPassword : LoginResult
{
    public WrongPassword(Account account)
        : base(account) { }
}