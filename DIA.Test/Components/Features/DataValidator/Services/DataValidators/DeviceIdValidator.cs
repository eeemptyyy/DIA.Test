using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidators;

/// <summary>
/// DeviceIdValidator implements the IDataValidator interface to validate device IDs.
/// </summary>
public class DeviceIdValidator : IDataValidator
{
    public DataValidatorType ValidatorType => DataValidatorType.DeviceId;

    public bool Validate(string? data)
    {
        // Check device number format
        return IsGuidFormat(data);
    }

    /// <summary>
    /// Checks if the given string is in a valid GUID format.
    /// </summary>
    /// <param name="data">The string to check.</param>
    /// <returns>True if the string is in a valid GUID format, otherwise false.</returns>
    /// <remarks>Returns false if the data parameter is null.</remarks>
    private bool IsGuidFormat(string? data)
    {
        return data != null && Guid.TryParse(data, out _);
    }
}