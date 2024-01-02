using DIA.Test.Components.Features.DataValidator.Models.PageModels.DataValidatorPage;
using DIA.Test.Components.Features.DataValidator.Services;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;
using DIA.Test.Components.Features.DataValidator.Services.DataValidators;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorServiceFolder;

namespace DIA.XUnitTestProject;

public class DataValidatorServiceTests
{
    private readonly DataValidatorService _dataValidatorService;

    public DataValidatorServiceTests()
    {
        _dataValidatorService = new DataValidatorService(new DataValidatorFactory(new IDataValidator[]
            { new PassportValidator(), new RnokppValidator(), new DeviceIdValidator(), new DateOfBirthValidator() }));
    }

    [Theory]
    [InlineData("СЮ112233", "01.01.2000", "1234567890", "3f2504e0-4f89-11d3-9a0c-0305e82c3301", true)]
    [InlineData("invalidPassportData", "1990-01-01", "validRnokppData", "validDeviceIdData", false)]
    public void ValidateData_ShouldReturnExpectedResult(
        string passport, string dob,
        string rnokpp, string deviceId,
        bool expectedResult)
    {
        var pageModel = new DataValidatorPageModel
        {
            Passport = passport,
            DateOfBirth = dob,
            Rnokpp = rnokpp,
            DeviceID = deviceId
        };

        var actualResult = _dataValidatorService.ValidateData(pageModel);

        Assert.Equal(expectedResult, actualResult);
    }
}