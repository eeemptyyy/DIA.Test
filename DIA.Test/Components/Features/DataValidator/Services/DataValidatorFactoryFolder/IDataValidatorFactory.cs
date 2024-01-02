using DIA.Test.Components.Features.DataValidator.Models.Enums;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;

public interface IDataValidatorFactory
{
    IDataValidator GetValidator(DataValidatorType validatorType);
}