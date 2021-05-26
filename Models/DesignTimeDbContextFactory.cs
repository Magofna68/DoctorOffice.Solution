using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DoctorOffice.Models
{
  public class DoctorOfficeContextFactory: IDesignTimeDbContextFactory<DoctorOfficeContext>
  {
    DoctorOfficeContextFactory IDesignTimeDbContextFactory<DoctorOfficeContext>.CreateDbContexTextReader.(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<DoctorOfficeContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"],
      ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new DoctorOfficeContext(builder.Options);
  }
}}