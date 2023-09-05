using System.ComponentModel.DataAnnotations;

namespace ConsoleApp_net_core
{
    public class ChucVu
    {
        [Key]
        public int? id { get; set; }
        public string? ma { get; set; }
        public string? ten { get; set; }
        
        public ChucVu(int? id, string? ma, string? ten)
        {
            this.id = id;
            this.ma = ma;
            this.ten = ten;
        }

        public ChucVu()
        {
        }
    }
}
