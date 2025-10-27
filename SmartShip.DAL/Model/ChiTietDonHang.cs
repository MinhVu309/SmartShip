namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        [StringLength(20)]
        public string MaChiTiet { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDon { get; set; }

        [Required]
        [StringLength(20)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(255)]
        public string TenHang { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ThanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
