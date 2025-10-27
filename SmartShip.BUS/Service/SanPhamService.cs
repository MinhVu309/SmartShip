using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamService
    {
        private Dbcontext db = new Dbcontext();

        // Lấy tất cả sản phẩm
        public List<SanPham> GetAll()
        {
            return db.SanPhams.ToList();
        }

        // Lấy sản phẩm theo ID
        public SanPham GetById(string id)
        {
            return db.SanPhams.Find(id);
        }

        // Thêm sản phẩm mới
        public void Them(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }

        // Cập nhật thông tin sản phẩm
        public void CapNhat(SanPham sp)
        {
            var old = db.SanPhams.Find(sp.MaSanPham);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(sp);
                db.SaveChanges();
            }
        }

        // Xóa sản phẩm
        public void Xoa(int id)
        {
            var sp = db.SanPhams.Find(id);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
            }
        }

        // Tìm kiếm sản phẩm theo tên
        public List<SanPham> TimKiem(string ten)
        {
            return db.SanPhams
                     .Where(s => s.TenSanPham.Contains(ten))
                     .ToList();
        }
    }
}
