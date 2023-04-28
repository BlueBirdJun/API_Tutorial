using API_Tutorial.Infra.OpenApi;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

namespace API_Tutorial.Configurations;

internal static partial class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddValidatorsFromAssembly(assembly)
            .AddMediatR(assembly)
            .AddApplicationInfrastructure(config);
        return services
            .AddApiVersioning()
            //.ServiceResist(config)
            //.AddCaching(config)
            //.AddHealthCheck()
            //.AddHub(config)
            //.AddCorsPolicy(config)
            .AddOpenApiDocumentation(config)
            //.AddAuth(config)            
            .AddRouting(options => options.LowercaseUrls = true);
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder builder, IConfiguration config)
    {
        return builder
                   .UseRequestLocalization()
                   .UseStaticFiles()
                   //.UseSecurityHeaders(config)
                   //.UseFileStorage()
                   //.UseExceptionMiddleware()
                   .UseHttpsRedirection()
                   .UseRouting()
                   //.UseCorsPolicy()
                   .UseAuthentication()
                   .UseAuthorization()
                   //.UseCurrentUser()
                   //.UseMultiTenancy() 
                   //.UseRequestLogging(config)
                   //.UseHangfireDashboard(config)
                   .UseOpenApiDocumentation(config);
    }

    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapControllers().RequireAuthorization();
        //builder.MapHealthCheck();
        //builder.MapNotifications();
        //builder.MapHub();
        return builder;
    }
}