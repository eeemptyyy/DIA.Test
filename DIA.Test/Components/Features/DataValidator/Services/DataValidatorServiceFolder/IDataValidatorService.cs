using DIA.Test.Components.Features.DataValidator.Models.PageModels.DataValidatorPage;

namespace DIA.Test.Components.Features.DataValidator.Services.DataValidatorServiceFolder;

public interface IDataValidatorService
{
    bool ValidateData(DataValidatorPageModel validatorPageModel);
}