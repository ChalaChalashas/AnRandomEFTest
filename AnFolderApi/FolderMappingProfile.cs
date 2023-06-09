using AutoMapper;

namespace AnFolderApi;

public class FolderMappingProfile : Profile
{
    public FolderMappingProfile()
    {
        CreateProjection<FolderEntity, FolderDto>();
        CreateMap<FolderDto, FolderEntity>();
    }
}