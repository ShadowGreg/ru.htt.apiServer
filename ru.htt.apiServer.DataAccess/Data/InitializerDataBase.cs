namespace ru.htt.apiServer.DataAccess.Data;

public class InitializerDataBase: IInitializerDb {
    private readonly DataContext _context;

    public InitializerDataBase(DataContext dbContext) {
        _context = dbContext;
    }

    public void InitializerDb() {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();

        _context.AddRange(FakeDataFactory.Categoryes);
        _context.SaveChanges();

        _context.AddRange(FakeDataFactory.Products);
        _context.SaveChanges();
        
        _context.AddRange(FakeDataFactory.JoinRequest);
        _context.SaveChanges();
    }
}