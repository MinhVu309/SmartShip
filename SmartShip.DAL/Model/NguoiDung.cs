namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            DiaChis = new HashSet<DiaChi>();
            DonHangs = new HashSet<DonHang>();
            Taixes = new HashSet<Taixe>();
        }

        [Key]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(255)]
        public string DiaChiMacDinh { get; set; }

        public bool? HoatDong { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(100)]
        public string ResetCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taixe> Taixes { get; set; }
    }
}
