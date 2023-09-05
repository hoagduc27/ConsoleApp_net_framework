
using Microsoft.EntityFrameworkCore;

namespace models
{
    public class Context:DbContext
    {
        public DbSet<NhanVien> nhanViens { get; set; }

        public DbSet<ChucVu> chucVus { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public Context()
        {
        }

    }
}
