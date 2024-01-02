using DIA.Test.Components.Features.DataValidator.Models.Enums;
using DIA.Test.Components.Features.DataValidator.Models.PageModels.DataValidatorPage;
using DIA.Test.Components.Features.DataValidator.Services;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorServiceFolder;
using Moq;

namespace DIA.XUnitTestProject;

public class DataValidatorServiceWithMoqTests
{
    private readonly Mock<IDataValidatorFactory> _dataValidatorFactoryMock;
    private readonly DataValidatorService _dataValidatorService;

    public DataValidatorServiceWithMoqTests()
    {
        _dataValidatorFactoryMock = new Mock<IDataValidatorFactory>();
        _dataValidatorService = new DataValidatorService(_dataValidatorFactoryMock.Object);
    }

    [Fact]
    public void ValidateData_SuccessfulTest()
    {
        // Arrange
        var validatorPageModel = new DataValidatorPageModel();
        _dataValidatorFactoryMock.Setup(x => x.GetValidator(It.IsAny<DataValidatorType>()))
            .Returns(() => new AlwaysValidValidator());

        // Act
        var result = _dataValidatorService.ValidateData(validatorPageModel);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ValidateData_UnsuccessfulTest()
    {
        // Arrange
        var validatorPageModel = new DataValidatorPageModel();
        _dataValidatorFactoryMock.Setup(x => x.GetValidator(It.IsAny<DataValidatorType>()))
            .Returns(() => new AlwaysInvalidValidator());

        // Act
        var result = _dataValidatorService.ValidateData(validatorPageModel);

        // Assert
        Assert.False(result);
    }
}

public class AlwaysValidValidator : IDataValidator
{
    public DataValidatorType ValidatorType { get; }

    public bool Validate(string? data)
    {
        return true;
    }
}

public class AlwaysInvalidValidator : IDataValidator
{
    public DataValidatorType ValidatorType { get; }

    public bool Validate(string? data)
    {
        return false;
    }
}