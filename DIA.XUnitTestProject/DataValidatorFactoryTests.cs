using DIA.Test.Components.Features.DataValidator.Models.Enums;
using DIA.Test.Components.Features.DataValidator.Services;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;
using Moq;

namespace DIA.XUnitTestProject;

public class DataValidatorFactoryTests
{
    private readonly Mock<IDataValidator> _dataValidatorMock;
    private readonly DataValidatorFactory _dataValidatorFactory;

    public DataValidatorFactoryTests()
    {
        _dataValidatorMock = new Mock<IDataValidator>();
        List<IDataValidator> dataValidators = [_dataValidatorMock.Object];
        _dataValidatorFactory = new DataValidatorFactory(dataValidators);
    }

    [Fact]
    public void GetValidator_ShouldReturnCorrectValidator()
    {
        // Arrange
        var expectedValidatorType = DataValidatorType.Passport; 
        _dataValidatorMock.Setup(v => v.ValidatorType).Returns(expectedValidatorType);

        // Act
        var actualValidator = _dataValidatorFactory.GetValidator(expectedValidatorType);

        // Assert
        _dataValidatorMock.Verify(v => v.ValidatorType, Times.Once);
        Assert.NotNull(actualValidator);
        Assert.Equal(expectedValidatorType, actualValidator.ValidatorType);
    }

    [Fact]
    public void GetValidator_ShouldThrowNotSupportedExceptionForUnsupportedValidator()
    {
        // Arrange
        var unexpectedValidatorType = (DataValidatorType)9999;

        // Act & Assert
        var exception = Assert.Throws<NotSupportedException>(() => _dataValidatorFactory.GetValidator(unexpectedValidatorType));
        Assert.Contains($"The validator type \"{unexpectedValidatorType}\" is not supported.", exception.Message);
    }
}