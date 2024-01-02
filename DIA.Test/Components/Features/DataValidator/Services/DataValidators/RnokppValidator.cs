using System.Text.RegularExpressions;
using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidators;

/// <summary>
/// Represents a data validator for Rnokpp data.
/// </summary>
public class RnokppValidator : IDataValidator
{
    // Extracted constant for the Regular Expression
    private const string RnokppPattern = @"^\d+$";   
        
    public DataValidatorType ValidatorType => DataValidatorType.Rnokpp;

    public bool Validate(string? data)
    {
        // Check Rnokpp for presence of 10 digits
        return data != null && data.Length == 10 && Regex.IsMatch(data, RnokppPattern);
    }
}