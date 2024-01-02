using DIA.Test.Components.Features.DataValidator.Services.DataValidators;

namespace DIA.XUnitTestProject.DataValidators;

public class PassportValidatorTests
{
    private readonly PassportValidator _validator;

    public PassportValidatorTests()
    {
        _validator = new PassportValidator();
    }

    [Theory]
    [InlineData("СЮ112233", true)]
    [InlineData("СЮ11223a", false)]
    [InlineData(null, false)]
    public void Validate_ShouldCheckIfPassportIsInCorrectFormat(string passport, bool expectedResult)
    {
        var result = _validator.Validate(passport);
        
        Assert.Equal(expectedResult, result);
    }
}