using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Models
{
  public class DoctorOfficeContext : Dbcontext
  {
    public virtual DbSet<Doctor> Doctor {get; set;}
    public DbSet<Patient> Patient {get; set;}
    public DbSet<DoctorPatient> DoctorPatient {get; set;}
    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
    protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}