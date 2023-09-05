
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_TestCodeFirst
{
    public class ProductsContext : DbContext
    {
        // Thuộc tính products kiểu DbSet<Product> cho biết CSDL có bảng mà
        // thông tin về bảng dữ liệu biểu diễn bởi model Product
        public DbSet<Product> products { set; get; }

        // Chuỗi kết nối tới CSDL (MS SQL Server)
        private const string connectionString =
            @"Server=HOAGDUC27\SQLEXPRESS;
    Database=CodeFirst;User Id=sa;
Password=123456;TrustServerCertificate=True;Trusted_Connection=True;";

        // Phương thức OnConfiguring gọi mỗi khi một đối tượng DbContext được tạo
        // Nạp chồng nó để thiết lập các cấu hình, như thiết lập chuỗi kết nối
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
