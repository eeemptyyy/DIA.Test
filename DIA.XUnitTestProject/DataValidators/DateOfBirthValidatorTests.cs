using DIA.Test.Components.Features.DataValidator.Services.DataValidators;

namespace DIA.XUnitTestProject.DataValidators;

public class DateOfBirthValidatorTests
{
    private readonly DateOfBirthValidator _validator;

    public DateOfBirthValidatorTests()
    {
        _validator = new DateOfBirthValidator();
    }

    [Theory]
    [InlineData("01.01.2000", true)]
    [InlineData("32.01.2000", false)]
    [InlineData("01.13.2000", false)]
    [InlineData("abcd", false)]
    public void Validate_Should_ReturnExpectedResult(string dateOfBirth, bool expectedResult)
    {
        // Act
        bool result = _validator.Validate(dateOfBirth);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}