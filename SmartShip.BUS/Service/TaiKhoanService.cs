using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShip.BUS.Service;
using SmartShip.DAL.Model;

namespace SmartShip.BUS.Service
{
    
    public class TaiKhoanService
    {
        private Dbcontext db = new Dbcontext();
        public List<Taikhoan> GetAll()
        {
            return db.Taikhoans.ToList();
        }

        public Taikhoan GetById(int id)
        {
            return db.Taikhoans.Find(id);
        }

        public Taikhoan DangNhap(string tenDangNhap, string matKhau)
        {
            return db.Taikhoans
                     .FirstOrDefault(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau);
        }
        public void Them(Taikhoan tk)
        {
            Them(tk, "Khách hàng mới", "0000000000", null);
        }

        // 🔹 Tạo mã tài khoản mới tự động
        private string GenerateMaTaiKhoan()
        {
            int max = 0;

            if (db.Taikhoans.Any())
            {
                max = db.Taikhoans
                        .AsEnumerable() // đưa về memory
                        .Select(t => int.Parse(t.MaTaiKhoan.Substring(2)))
                        .Max();
            }

            return "TK" + (max + 1).ToString("D3"); // luôn trả về giá trị
        }

        // 🔹 Thêm tài khoản mới (tự sinh MaTaiKhoan)
        public void Them(Taikhoan tk, string hoTen, string sdt, string diaChi = null)
        {
            if (string.IsNullOrEmpty(tk.MaTaiKhoan))
            {
                tk.MaTaiKhoan = GenerateMaTaiKhoan();
            }

            try
            {
                tk.NgayTao = DateTime.Now;
                tk.TrangThai = true;
                db.Taikhoans.Add(tk);
                db.SaveChanges();

                var nguoiDung = new NguoiDung
                {
                    MaNguoiDung = "ND" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper(),
                    MaTaiKhoan = tk.MaTaiKhoan,
                    HoTen = hoTen,
                    SDT = string.IsNullOrEmpty(sdt) ? "0000000000" : sdt,
                    DiaChiMacDinh = diaChi,
                    Email = tk.Email,
                    VaiTro = tk.VaiTro,
                    HoatDong = true,
                    NgayTao = DateTime.Now
                };

                db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string errors = string.Join("\n", ex.EntityValidationErrors
                    .SelectMany(e => e.ValidationErrors)
                    .Select(e => $"{e.PropertyName}: {e.ErrorMessage}"));

                throw new Exception("❌ Validation Error:\n" + errors);
            }
        }

        public void CapNhat(Taikhoan tk)
        {
            var old = db.Taikhoans.Find(tk.MaTaiKhoan); // ok nếu MaTaiKhoan là string
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(tk);
                db.SaveChanges();
            }
        }

        public void Xoa(string maTaiKhoan)
        {
            var tk = db.Taikhoans.Find(maTaiKhoan);
            if (tk != null)
            {
                db.Taikhoans.Remove(tk);
                db.SaveChanges();
            }
        }
        public Taikhoan KiemTraResetCode(string email, string code)
        {
            return db.Taikhoans.FirstOrDefault(u => u.Email == email && u.ResetCode == code);
        }

        // 🔹 Đặt lại mật khẩu
        public bool DatLaiMatKhau(string email, string newPass)
        {
            var user = db.Taikhoans.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return false;

            user.MatKhau = newPass;
            user.ResetCode = null;
            db.SaveChanges();
            return true;
        }
    }
}
