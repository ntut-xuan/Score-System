using AutoMapper;
using ScoreSystem.ApplicationContract;
using ScoreSystem.EFCore.Model;

namespace ScoreSystem.Domain.MappingProfiles;

public class ScoreSystemMapping : Profile
{
    public ScoreSystemMapping()
    {
        CreateMap<ScoreRecordInput, ScoreSystemModel>();
    }
}