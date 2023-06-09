namespace AnFolderApi;

public class FolderDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<FolderDto> Children { get; set; } = new List<FolderDto>();
}