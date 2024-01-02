using DIA.Test.Components.Features.DataValidator.Services.DataValidators;

namespace DIA.XUnitTestProject.DataValidators;

public class RnokppValidatorTests
{
    private RnokppValidator validator;

    public RnokppValidatorTests(){
        validator = new RnokppValidator();
    }
        
    [Fact]
    public void Validate_ReturnsTrueForValidRnokppData()
    {
        // Arrange
        var validRnokppData = "1234567890"; // A valid Rnokpp data
            
        // Act
        var result = validator.Validate(validRnokppData);
            
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Validate_ReturnsFalseForInvalidRnokppData()
    {
        // Arrange
        var invalidRnokppData = "abc123"; // An invalid Rnokpp data
            
        // Act
        var result = validator.Validate(invalidRnokppData);
            
        // Assert
        Assert.False(result);
    }
}