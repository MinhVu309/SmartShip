using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class DonHangService
    {
        private Dbcontext db = new Dbcontext();

        public List<DonHang> GetAll()
        {
            return db.DonHangs.ToList();
        }

        public DonHang GetById(string id)
        {
            return db.DonHangs.Find(id);
        }

        public List<DonHang> GetByTaiXe(string maTaiXe)
        {
            return db.DonHangs.Where(d => d.MaTaiXe == maTaiXe).ToList();
        }

        public void CapNhatTrangThai(string maDon, string trangThai)
        {
            var dh = db.DonHangs.Find(maDon);
            if (dh != null)
            {
                dh.TrangThai = trangThai;
                db.SaveChanges();
            }
        }

        public void Them(DonHang dh)
        {
            db.DonHangs.Add(dh);
            db.SaveChanges();
        }

        public void CapNhat(DonHang dh)
        {
            var old = db.DonHangs.Find(dh.MaDon);
            if (old != null)
            {
                if (!string.IsNullOrEmpty(dh.MaTaiXe))
                {
                    var taiXe = db.Taixes.Find(dh.MaTaiXe);
                    if (taiXe != null)
                    {
                        taiXe.TongDon += 1;
                        db.Entry(taiXe).State = System.Data.Entity.EntityState.Modified;
                    }
                }
            }
            db.Entry(old).CurrentValues.SetValues(dh);
            db.SaveChanges();
        }
        public List<DonHang> TimDonHang(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return db.DonHangs.ToList();

            // Cho phép tìm gần đúng 
            return db.DonHangs
                     .Where(d => d.MaDon.Contains(keyword))
                     .ToList();
        }
        public void Xoa(string id)
        {
            var dh = db.DonHangs.Find(id);
            if (dh != null)
            {
                db.DonHangs.Remove(dh);
                db.SaveChanges();
            }
        }
        public List<DonHang> GetDonHangByTaiXe(string maTaiXe)
        {
            return db.DonHangs
                     .Where(d => d.MaTaiXe == maTaiXe)
                     .ToList();
        }
    }
}
