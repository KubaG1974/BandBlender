namespace BandBlender;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("YourDbConnection")));

        // Będzie uzupełniane
    }
  
}