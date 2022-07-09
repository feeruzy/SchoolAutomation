using Microsoft.EntityFrameworkCore;

namespace School.Core;
public class ModelDb : DbContext
{

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=SchoolAutoDb;Trusted_Connection=True;");
      // optionsBuilder.UseSqlServer(_configuration["cnx"]);  // todo
    }
  }

  // database table class here.
  public virtual DbSet<ClassYear> tblYears { get; set; }
}
