namespace Library.BLL.Models.Validators.Common;

public static class UserValidationRules
{
    public static IRuleBuilderOptions<T, string> ApplyLoginRules<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty().WithMessage("Login can't be empty")
            .Length(3, 20).WithMessage("Login must be between 3 and 20 characters")
            .Matches("^[a-zA-Z0-9_]*$").WithMessage("Login can only contain letters, numbers, and underscore");
    }

    public static IRuleBuilderOptions<T, string> ApplyPasswordRules<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty().WithMessage("Password can't be empty")
            .Length(5, 100).WithMessage("Password must be between 5 and 100 characters");
    }
}
