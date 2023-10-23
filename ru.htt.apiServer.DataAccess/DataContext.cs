using Microsoft.EntityFrameworkCore;
using ru.htt.apiServer.Core.Domain;

namespace ru.htt.apiServer.DataAccess;

public class DataContext: DbContext {
    public DbSet<Category> Categoryes { get; set; }

    public DbSet<Product> Products { get; set; }
    
    public DbSet<JoinRequest> JoinRequest { get; set; }
    
    public DataContext() { }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }
}