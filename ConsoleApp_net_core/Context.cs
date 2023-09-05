using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_net_core
{
    public class Context:DbContext
    {
        public DbSet<NhanVien> nhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("\"Data Source=HOAGDUC27\\\\SQLEXPRESS;Initial Catalog=CodeFirst;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=true\"");

        }

        public Context()
        {
        }
    }
}
