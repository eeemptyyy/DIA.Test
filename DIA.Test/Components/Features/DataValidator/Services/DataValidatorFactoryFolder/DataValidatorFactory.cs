using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;

/// <summary>
///     Factory class responsible for creating and providing different data validators.
/// </summary>
public class DataValidatorFactory : IDataValidatorFactory
{
    private readonly IEnumerable<IDataValidator> _dataValidators;
    
    public DataValidatorFactory(IEnumerable<IDataValidator> dataValidators)
    {
        _dataValidators = dataValidators;
    }

    /// <summary>
    /// Retrieves a data validator.
    /// </summary>
    /// <param name="validatorType">The type of data validator to retrieve.</param>
    /// <returns>
    /// The data validator for the specified type.
    /// </returns>
    /// <exception cref="NotSupportedException">
    /// Thrown when the specified validator type is not supported.
    /// </exception>
    public IDataValidator GetValidator(DataValidatorType validatorType)
    {
        var validator = _dataValidators.FirstOrDefault(x => x.ValidatorType == validatorType);
        
        if (validator is null)
        {
            throw new NotSupportedException($"The validator type \"{validatorType}\" is not supported.");
        }

        return validator;
    }
}