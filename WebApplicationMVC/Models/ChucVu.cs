using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVC.Models
{
    [Table("chuc_vu")]
    public class ChucVu
    {
        [Key]
        public int? id { get; set; }
        [MaxLength(50)]
        public string? ma { get; set; }
        [MaxLength(50)]
        public string? ten { get; set; }
        
        public ChucVu(int id, string? ma, string? ten)
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
