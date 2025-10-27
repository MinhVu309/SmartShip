namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanCong")]
    public partial class PhanCong
    {
        [Key]
        [StringLength(20)]
        public string MaPhanCong { get; set; }

        [Required]
        [StringLength(20)]
        public string MaDon { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTaiXe { get; set; }

        public DateTime? NgayGiao { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual Taixe Taixe { get; set; }
    }
}
