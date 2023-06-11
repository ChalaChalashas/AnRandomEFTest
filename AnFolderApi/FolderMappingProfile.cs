using AutoMapper;

namespace AnFolderApi;

public class FolderMappingProfile : Profile
{
    public FolderMappingProfile()
    {
        CreateMap<FolderEntity, FolderDto>()
            .ForMember(d => d.Children, o => o.MapFrom(s => s.Children));
        CreateMap<FolderDto, FolderEntity>();
    }
}