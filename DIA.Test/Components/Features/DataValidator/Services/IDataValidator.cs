using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services;

/// <summary>
///     Represents a data validator that can validate string data.
/// </summary>
public interface IDataValidator
{
    public DataValidatorType ValidatorType { get; }
    bool Validate(string? data);
}