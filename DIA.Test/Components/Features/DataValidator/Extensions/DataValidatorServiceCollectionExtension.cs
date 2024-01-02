using DIA.Test.Components.Features.DataValidator.Services;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorFactoryFolder;
using DIA.Test.Components.Features.DataValidator.Services.DataValidators;
using DIA.Test.Components.Features.DataValidator.Services.DataValidatorServiceFolder;

namespace DIA.Test.Components.Features.DataValidator.Extensions;

/// <summary>
///     Provides extension methods for initializing data validator services.
/// </summary>
public static class DataValidatorServiceCollectionExtension
{
    /// <summary>
    ///     Initializes the data validator services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection with the initialized services.</returns>
    public static IServiceCollection InitDataValidatorServices(this IServiceCollection services)
    {
        #region Singleton

        services.AddSingleton<IDataValidator, DateOfBirthValidator>();
        services.AddSingleton<IDataValidator, DeviceIdValidator>();
        services.AddSingleton<IDataValidator, PassportValidator>();
        services.AddSingleton<IDataValidator, RnokppValidator>();

        services.AddSingleton<IDataValidatorFactory, DataValidatorFactory>();
        services.AddSingleton<IDataValidatorService, DataValidatorService>();

        #endregion

        return services;
    }
}