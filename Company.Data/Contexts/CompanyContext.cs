using Company.Data.Entities;

namespace Company.Data.Contexts;

public class CompanyContext : DbContext
{

    public DbSet<ACompany> Companies => Set<ACompany>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();
    public DbSet<Position> Positions => Set<Position>();
    public DbSet<Section> Sections => Set<Section>();

    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options )
	{

	}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<EmployeePosition>()
             .HasKey(fg => new { fg.EmployeeID, fg.PositionID });
        //SeedData(builder);
    }


    //private void SeedData(ModelBuilder builder)
    //{
    // ????
    //}

}
