namespace SmartShip.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaChi")]
    public partial class DiaChi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiaChi()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(20)]
        public string MaDiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChiChiTiet { get; set; }

        public bool? MacDinh { get; set; }

        public DateTime? NgayTao { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
