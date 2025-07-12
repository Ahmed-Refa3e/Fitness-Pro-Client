namespace Fitness_Pro_Client.Validations;

public class ComplexPasswordAttribute : ValidationAttribute
{
    public ComplexPasswordAttribute()
    {
        ErrorMessage = "Password must be at least 6 characters and contain an uppercase letter, a lowercase letter, a number, and a special character.";
    }

    public override bool IsValid(object? value)
    {
        string? password = value as string;
        if (string.IsNullOrWhiteSpace(password))
            return false;

        return
            password.Length >= 6 &&
            Regex.IsMatch(password, "[A-Z]") &&
            Regex.IsMatch(password, "[a-z]") &&
            Regex.IsMatch(password, "[0-9]") &&
            Regex.IsMatch(password, @"[\W_]");
    }
}
