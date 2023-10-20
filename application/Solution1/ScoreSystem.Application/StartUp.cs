using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RazorLight;
using RazorLight.Extensions;
using ScoreSystem.Application;
using ScoreSystem.ApplicationContract;
using ScoreSystem.Domain.MappingProfiles;
using ScoreSystem.EFCore;

namespace ScoreSystem.Application;

public static class StartUp
{
    public static void AddAppService(this IServiceCollection services)
    {
        services.AddEFService();
        services.AddAutoMapper(typeof(ScoreSystemMapping).Assembly);
        services.AddTransient<IScoreAppService, ScoreAppService>();
    }
}