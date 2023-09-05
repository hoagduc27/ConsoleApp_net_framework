using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace asp_mvc.Models
{
    [Table("nhan_vien")]
    public class NhanVien
    {
        [Key]
        public int? id { get; set; }

        [Required(ErrorMessage = "Username is not blank")]
        [MaxLength(50, ErrorMessage = "At most 50 characters")]
        [MinLength(2, ErrorMessage = "At least 2 characters")]
        public string? username { get; set; }
        [Required(ErrorMessage = "Password is not blank")]
        [MinLength(2, ErrorMessage = "At least 2 characters")]
        [MaxLength(50, ErrorMessage = "At most 50 characters")]
        public string? password { get; set; }

        public int? chucVuId;

        [ForeignKey("chucVuId")]
        public ChucVu? chucVu { get; set; }

        public NhanVien(int? id, string? name, string? password)
        {
            this.id = id;
            this.username = name;
            this.password = password;
        }

        public NhanVien()
        {
        }

        public NhanVien(int chucVuId, int? id, string? username, string? password)
        {
            this.chucVuId = chucVuId;
            this.id = id;
            this.username = username;
            this.password = password;
        }
    }
}
