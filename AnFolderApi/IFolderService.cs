namespace AnFolderApi;

public interface IFolderService
{
    FolderDto AddFolder(FolderDto folder, int? parentId);
    FolderDto? GetFolder(int id);
    IEnumerable<FolderDto> GetTree();
}