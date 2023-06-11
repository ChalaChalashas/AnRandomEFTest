using AutoMapper;

namespace AnFolderApi;

public class FolderMappingProfile : Profile
{
    public FolderMappingProfile()
    {
        CreateMap<FolderEntity, FolderDto>();
        CreateMap<FolderDto, FolderEntity>();
    }
}