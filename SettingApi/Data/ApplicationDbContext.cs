using Microsoft.EntityFrameworkCore;
using SettingApi.Entities.Models;

namespace SettingApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<EmailSettings> EmailSettings { get; set; }
    public DbSet<PushSettings> PushSettings { get; set; }
    public DbSet<SmsSettings> SmsSettings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EmailSettings>().HasKey(x => x.UserId);
        modelBuilder.Entity<PushSettings>().HasKey(x => x.UserId);
        modelBuilder.Entity<SmsSettings>().HasKey(x => x.UserId);

        modelBuilder.Entity<EmailSettings>().ToTable("EmailSettings");
        modelBuilder.Entity<PushSettings>().ToTable("PushSettings");
        modelBuilder.Entity<SmsSettings>().ToTable("SmsSettings");
    }
}
