using System.Text.RegularExpressions;
using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidators;

/// <summary>
/// The PassportValidator class is responsible for validating passport data.
/// </summary>
public class PassportValidator : IDataValidator
{
    // Extracted passport number pattern for better readability and maintainability.
    private const string PassportNumberPattern = @"^[А-Я]{2}\d{6}$";

    public DataValidatorType ValidatorType => DataValidatorType.Passport;

    public bool Validate(string? data)
    {
        // Check if passport format is: СЮ112233. Adjust the PassportNumberPattern accordingly.
        return data != null && Regex.IsMatch(data, PassportNumberPattern);
    }
}