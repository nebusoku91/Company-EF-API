namespace Company.Data.Contexts;

internal class CompanyContext : DbContext
{
	public CompanyContext(DbContextOptions<CompanyContext> options) : base(options )
	{

	}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
