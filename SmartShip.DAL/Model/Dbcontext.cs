using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SmartShip.DAL.Model
{
    public partial class Dbcontext : DbContext
    {
        public Dbcontext()
            : base("name=Dbcontext")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Taixe> Taixes { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaDon)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.DonGia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(21, 2);

            modelBuilder.Entity<DiaChi>()
                .Property(e => e.MaDiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<DiaChi>()
                .Property(e => e.MaNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<DiaChi>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.DiaChi)
                .HasForeignKey(e => e.MaDiaChiGiao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDon)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaKhach)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDiaChiGiao)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaTaiXe)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.COD)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.DiaChis)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.NguoiDung)
                .HasForeignKey(e => e.MaKhach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.Taixes)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.MaPhanCong)
                .IsUnicode(false);

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.MaDon)
                .IsUnicode(false);

            modelBuilder.Entity<PhanCong>()
                .Property(e => e.MaTaiXe)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.NguoiDungs)
                .WithRequired(e => e.Taikhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taixe>()
                .Property(e => e.MaTaiXe)
                .IsUnicode(false);

            modelBuilder.Entity<Taixe>()
                .Property(e => e.MaNguoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<Taixe>()
                .Property(e => e.Diem)
                .HasPrecision(3, 2);

            modelBuilder.Entity<Taixe>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.Taixe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.MaThanhToan)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.MaDon)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.SoTien)
                .HasPrecision(10, 2);
        }
    }
}
