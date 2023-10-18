using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ScoreSystem.Domain;
using ScoreSystem.EFCore.MappingProfile;

namespace ScoreSystem.EFCore;

public static class StartUp
{
    public static void AddEFService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ScoreSystemRepositoryMapping).Assembly);
        services.AddTransient<IEFScoreSystem, EFScoreSystem>();
    }
}