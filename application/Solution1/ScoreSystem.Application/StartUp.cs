using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ScoreSystem.Application;
using ScoreSystem.ApplicationContract;
using ScoreSystem.Domain.MappingProfiles;
using ScoreSystem.EFCore;

namespace ScoreSystem.Domin;

public static class StartUp
{
    public static void AddAppService(this IServiceCollection services)
    {
        services.AddEFService();
        services.AddAutoMapper(typeof(ScoreSystemMapping).Assembly);
        services.AddTransient<IScoreAppService, ScoreAppService>();
    }
}