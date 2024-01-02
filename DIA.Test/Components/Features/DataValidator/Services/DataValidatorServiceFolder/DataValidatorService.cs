using DIA.Test.Components.Features.DataValidator.Models.Enums;
using DIA.Test.Components.Features.DataValidator.Models.PageModels.DataValidatorPage;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidatorServiceFolder;

public class DataValidatorService : IDataValidatorService
{
    private readonly IDataValidatorFactory _dataValidatorFactory;

    public DataValidatorService(IDataValidatorFactory dataValidatorFactory)
    {
        _dataValidatorFactory = dataValidatorFactory;
    }

    /// <summary>
    ///     Validates the data in the given DataValidatorPageModel.
    /// </summary>
    /// <param name="validatorPageModel">The DataValidatorPageModel object containing the data to validate.</param>
    /// <returns>True if all data is valid; otherwise, false.</returns>
    public bool ValidateData(DataValidatorPageModel validatorPageModel)
    {
        var validationResults = new[]
        {
            ValidateDataByType(validatorPageModel.Passport, DataValidatorType.Passport),
            ValidateDataByType(validatorPageModel.DateOfBirth, DataValidatorType.DateOfBirth),
            ValidateDataByType(validatorPageModel.Rnokpp, DataValidatorType.Rnokpp),
            ValidateDataByType(validatorPageModel.DeviceID, DataValidatorType.DeviceId)
        };

        return validationResults.All(x => x);
    }

    /// <summary>
    ///     Validates the given data by the specified data validator type.
    /// </summary>
    /// <param name="data">The data to be validated.</param>
    /// <param name="validatorType">The type of data validator to use.</param>
    /// <returns>True if the data is valid according to the specified validator type; otherwise, false.</returns>
    private bool ValidateDataByType(string? data, DataValidatorType validatorType)
    {
        var validator = _dataValidatorFactory.GetValidator(validatorType);
        return validator.Validate(data);
    }
}