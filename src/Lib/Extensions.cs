using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace FlintSoft.Version;

public static class Extensions
{
    public static IServiceCollection AddFlintSoftVersion(this IServiceCollection services, Assembly assembly)
    {
        services.AddSingleton(new Version(assembly));

        return services;
    }

    public static string GetVersion(this Assembly assembly) {
        var v = new Version(assembly);
        return v.GetVersion();
    }
}
