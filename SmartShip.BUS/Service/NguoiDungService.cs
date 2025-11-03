using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class NguoiDungService
    {
        private Dbcontext db = new Dbcontext();

        // 🔹 Lấy danh sách khách hàng
        public List<NguoiDung> GetKhachHang()
        {
            return db.NguoiDungs
                     .Where(x => x.VaiTro != null && x.VaiTro.Trim().ToLower() == "khách hàng")
                     .ToList();
        }

        // 🔹 Lấy toàn bộ người dùng
        public List<NguoiDung> GetAll()
        {
            return db.NguoiDungs.ToList();
        }

        // 🔹 Lấy người dùng theo ID
        public NguoiDung GetById(string id)
        {
            return db.NguoiDungs.Find(id);
        }

        // 🔹 Thêm mới người dùng
        public void Them(NguoiDung nd)
        {
            db.NguoiDungs.Add(nd);
            db.SaveChanges();
        }

        // ✅ Cập nhật người dùng (chỉ 4 trường được phép chỉnh sửa)
        public void CapNhat(NguoiDung nd)
        {
            var old = db.NguoiDungs.Find(nd.MaNguoiDung);
            if (old != null)
            {
                // 🔸 Chỉ cho phép cập nhật các trường này
                old.HoTen = nd.HoTen;
                old.SDT = nd.SDT;
                old.DiaChiMacDinh = nd.DiaChiMacDinh;
                old.HoatDong = nd.HoatDong;

                // 🔸 Không chạm tới các trường khác như MaTaiKhoan, VaiTro, Email, NgayTao...
                db.SaveChanges();
            }
        }

        // 🔹 Xóa người dùng
        public void Xoa(string id)
        {
            var nd = db.NguoiDungs.Find(id);
            if (nd != null)
            {
                db.NguoiDungs.Remove(nd);
                db.SaveChanges();
            }
        }
    }
}