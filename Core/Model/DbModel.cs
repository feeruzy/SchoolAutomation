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
    public virtual DbSet<ClassUser> tblUsers { get; set; }
    public virtual DbSet<ClassDiscipline> tblDisciplines { get; set; }
    public virtual DbSet<ClassStudent> tblStudents { get; set; }
    public virtual DbSet<ClassDiciplineStudent> tblDisciplineStudents { get; set; }
}
