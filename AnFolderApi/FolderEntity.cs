namespace AnFolderApi;

public class FolderEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? ParentId { get; set; }
    public FolderEntity? Parent { get; set; }
    public IEnumerable<FolderEntity> Children { get; set; } = new List<FolderEntity>();
}