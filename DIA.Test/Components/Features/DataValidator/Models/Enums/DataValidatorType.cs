namespace DIA.Test.Components.Features.DataValidator.Models.Enums;

/// <summary>
/// Enumeration representing various data validator types.
/// </summary>
public enum DataValidatorType
{
    /// <summary>
    /// Represents data validator type for DateOfBirth.
    /// </summary>
    /// <remarks>
    /// The DateOfBirth data validator is used to validate the date of birth of an individual.
    /// </remarks>
    DateOfBirth,

    /// <summary>
    /// Represents data validator type for DeviceId.
    /// </summary>
    /// <remarks>
    /// The DeviceId data validator is used to validate the device identity of an individual's device.
    /// </remarks>
    DeviceId,

    /// <summary>
    /// Represents data validator type for Passport.
    /// </summary>
    /// <remarks>
    /// The Passport data validator is used to validate the passport number of an individual.
    /// </remarks>
    Passport,

    /// <summary>
    /// Represents data validator type for Rnokpp.
    /// </summary>
    /// <remarks>
    /// Rnokpp (National Register of Legal Entities and Individual Entrepreneurs) data validator is used to validate the Rnokpp number of legal entities and individual entrepreneurs.
    /// </remarks>
    Rnokpp
}