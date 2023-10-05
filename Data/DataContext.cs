using Microsoft.EntityFrameworkCore;
using DJValeting.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string? connectionString = _configuration.GetConnectionString("UserConnection");
        options.UseSqlServer(connectionString);
    }

    public DbSet<AppointmentEntity> Appointments { get; set; }
}