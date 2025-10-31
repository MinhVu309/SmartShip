namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taikhoan")]
    public partial class Taikhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taikhoan()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        [Key]
        [StringLength(20)]
        public string MaTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }

        [StringLength(20)]
        public string VaiTro { get; set; }

        public bool? TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string ResetCode { get; set; }

        public string SDT { get; set; }
        public string HoTen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
