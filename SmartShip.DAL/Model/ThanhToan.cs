namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        [Key]
        [StringLength(20)]
        public string MaThanhToan { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDon { get; set; }

        public decimal SoTien { get; set; }

        [StringLength(20)]
        public string PhuongThuc { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
