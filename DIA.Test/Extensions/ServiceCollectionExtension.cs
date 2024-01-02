using DIA.Test.Components.Features.DataValidator.Extensions;

namespace DIA.Test.Extensions;

/// <summary>
///     Provides extension methods for the IServiceCollection interface.
/// </summary>
public static class ServiceCollectionExtension
{
    /// <summary>
    ///     Initializes services required for data validation.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> to add the services to.</param>
    /// <param name="configuration">The <see cref="ConfigurationManager" /> instance for configuration.</param>
    /// <returns>The modified <see cref="IServiceCollection" />.</returns>
    public static IServiceCollection InitServices(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.InitDataValidatorServices();

        return services;
    }
}