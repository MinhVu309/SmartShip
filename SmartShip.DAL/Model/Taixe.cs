namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taixe")]
    public partial class Taixe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taixe()
        {
            DonHangs = new HashSet<DonHang>();
            PhanCongs = new HashSet<PhanCong>();
        }

        [Key]
        [StringLength(20)]
        public string MaTaiXe { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [StringLength(20)]
        public string LoaiXe { get; set; }

        [StringLength(50)]
        public string BienSo { get; set; }

        public decimal? Diem { get; set; }

        public int? TongDon { get; set; }

        public bool? SanSang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
