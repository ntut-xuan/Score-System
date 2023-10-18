using AutoMapper;
using ScoreSystem.EFCore.Model;

namespace ScoreSystem.EFCore.MappingProfile;

public class ScoreSystemRepositoryMapping : Profile
{
    public ScoreSystemRepositoryMapping()
    {
        CreateMap<ScoreSystemModel, ScoreRecord>();
    }
}