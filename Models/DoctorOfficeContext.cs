using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Models
{
  public class DoctorOfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctor {get; set;}
    public DbSet<Patient> Patient {get; set;}
    public DbSet<DoctorPatient> DoctorPatient {get; set;}
    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}