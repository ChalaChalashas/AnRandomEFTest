using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace AnFolderApi;

public class FolderService : IFolderService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public FolderService(IMapper mapper, DataContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public FolderDto AddFolder(FolderDto folder, int? parentId)
    {
        var entity = _mapper.Map<FolderDto, FolderEntity>(folder);
        entity.ParentId = parentId;
        var added = _context.Folders.Add(entity);
        _context.SaveChanges();
        return _context.Folders
            .Where(x => x.Id == added.Entity.Id)
            .ProjectTo<FolderDto>(_mapper.ConfigurationProvider)
            .Single();
    }

    public FolderDto? GetFolder(int id)
    {
        return _context.Folders
            .Where(x => x.Id == id)
            .ProjectTo<FolderDto>(_mapper.ConfigurationProvider)
            .Single();
    }

    public IEnumerable<FolderDto> GetTree()
    {
        var query = _context.Folders.Where(x => x.ParentId == null);
        return _mapper.ProjectTo<FolderDto>(query);
    }
}