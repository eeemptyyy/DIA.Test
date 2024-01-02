using DIA.Test.Components.Features.DataValidator.Services.DataValidators;

namespace DIA.XUnitTestProject.DataValidators;

public class DeviceIdValidatorTests
{
    private readonly DeviceIdValidator _validator;

    public DeviceIdValidatorTests()
    {
        _validator = new DeviceIdValidator();
    }

    [Theory]
    [InlineData(null, false)]
    [InlineData("", false)]
    [InlineData("invalidGUID", false)]
    [InlineData("3f2504e0-4f89-11d3-9a0c-0305e82c3301", true)]
    public void Validate_Test(string data, bool expected)
    {
        var result = _validator.Validate(data);

        Assert.Equal(expected, result);
    }
}