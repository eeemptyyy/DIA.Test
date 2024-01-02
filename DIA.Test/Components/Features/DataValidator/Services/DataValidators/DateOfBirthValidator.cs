using System.Globalization;
using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidators;

/// <summary>
/// Represents a class for validating date of birth data.
/// </summary>
/// <summary>
/// Represents a class for validating date of birth data.
/// </summary>
public class DateOfBirthValidator : IDataValidator
{
    public DataValidatorType ValidatorType => DataValidatorType.DateOfBirth;

    /// <summary>
    /// Validates the date of birth string. Expected format: dd.MM.yyyy
    /// </summary>
    /// <param name="data">The string representation of the date of birth.</param>
    /// <returns>Returns true if the format is correct; false otherwise.</returns>
    public bool Validate(string? data)
    {
        return data != null && DateTime.TryParseExact(data, "dd.MM.yyyy", null, DateTimeStyles.None, out _);
    }
}