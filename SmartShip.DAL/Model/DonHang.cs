namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            PhanCongs = new HashSet<PhanCong>();
            ThanhToans = new HashSet<ThanhToan>();
        }

        [Key]
        [StringLength(20)]
        public string MaDon { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhach { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDiaChiGiao { get; set; }

        [StringLength(20)]
        public string MaTaiXe { get; set; }

        [StringLength(20)]
        public string Loai { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public decimal? COD { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public string GhiChu { get; set; }

        public DateTime? NgayTao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual DiaChi DiaChi { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual Taixe Taixe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
