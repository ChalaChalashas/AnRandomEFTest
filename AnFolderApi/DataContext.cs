using Microsoft.EntityFrameworkCore;

namespace AnFolderApi;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<FolderEntity> Folders => Set<FolderEntity>();
}