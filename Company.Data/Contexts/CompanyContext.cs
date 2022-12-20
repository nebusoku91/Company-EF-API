namespace Company.Data.Contexts;

public class CompanyContext : DbContext
{

    public DbSet<ACompany> ACompanys => Set<ACompany>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();
    public DbSet<Position> Positions => Set<Position>();
    public DbSet<Section> Sections => Set<Section>();

    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<EmployeePosition>()
             .HasKey(ep => new { ep.EmployeeID, ep.PositionID });
        //SeedData(builder);
        //SeedData2(builder);
    }


    private void SeedData(ModelBuilder builder)
    {
        var companies = new List<ACompany>
        {
            new ACompany
            {
                ID = 1,
                ACompanyName = "Företag 1",
                OrganizationNumber = 115435
            },
            new ACompany
            {
                ID = 2,
                ACompanyName = "Företag 2",
                OrganizationNumber = 234534
            },
            new ACompany
            {
                ID = 3,
                ACompanyName = "Företag 3",
                OrganizationNumber = 099482
            }
        };
        builder.Entity<ACompany>().HasData(companies);
        var sections = new List<Section>
        {
            new Section
            {
                ID = 1,
                SectionName = "Avdelning 1",
                ACompanyID = 3
            },
            new Section
            {
                ID = 2,
                SectionName = "Avdelning 2",
                ACompanyID = 1
            },
            new Section
            {
                ID = 3,
                SectionName = "Avdelning 3",
                ACompanyID = 2
            }
        };
        builder.Entity<Section>().HasData(sections);
        var employees = new List<Employee>
        {
            new Employee
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                Salary = 5000,
                Union = true,
                SectionID = 1
            },
            new Employee
            {
                ID = 2,
                FirstName = "Matt",
                LastName = "Damon",
                Salary = 9000,
                Union = false,
                SectionID = 3
            },
            new Employee
            {
                ID = 3,
                FirstName = "Margot",
                LastName = "Robbie",
                Salary = 13000,
                Union = true,
                SectionID = 2
            }

    };
        builder.Entity<Employee>().HasData(employees);
        var positions = new List<Position>
        {
            new Position
            {
                ID = 1,
                PositionName = "Position 1"
            },
            new Position
            {
                ID = 2,
                PositionName = "Position 2"
            },
            new Position
            {
                ID = 3,
                PositionName = "Position 3"
            }
        };
        builder.Entity<Position>().HasData(positions);
        var employeepositions = new List<EmployeePosition>
        {
            new EmployeePosition
            {
                EmployeeID = 1,
                PositionID = 3
            },
            new EmployeePosition
            {
                EmployeeID = 3,
                PositionID = 1
            },
            new EmployeePosition
            {
                EmployeeID = 2,
                PositionID = 2
            }
        };
        builder.Entity<EmployeePosition>().HasData(employeepositions);

}
    private void SeedData2(ModelBuilder builder)
    {
        var positions = new List<Position>
        {
            new Position
            {
                ID = 1,
                PositionName = "Position 1"
            },
            new Position
            {
                ID = 2,
                PositionName = "Position 2"
            },
            new Position
            {
                ID = 3,
                PositionName = "Position 3"
            }
        };
        builder.Entity<Position>().HasData(positions);

    }
}
