using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChiTietDonHangService
    {
        private Dbcontext db = new Dbcontext();

        public List<ChiTietDonHang> GetAll()
        {
            return db.ChiTietDonHangs.ToList();
        }

        public List<ChiTietDonHang> GetByDon(string maDon)
        {
            return db.ChiTietDonHangs.Where(x => x.MaDon == maDon).ToList();
        }

        public ChiTietDonHang GetById(string id)
        {
            return db.ChiTietDonHangs.Find(id);
        }

        public void Them(ChiTietDonHang ct)
        {
            db.ChiTietDonHangs.Add(ct);
            db.SaveChanges();
        }

        public void CapNhat(ChiTietDonHang ct)
        {
            var old = db.ChiTietDonHangs.Find(ct.MaChiTiet);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(ct);
                db.SaveChanges();
            }
        }

        public void Xoa(string id)
        {
            var ct = db.ChiTietDonHangs.Find(id);
            if (ct != null)
            {
                db.ChiTietDonHangs.Remove(ct);
                db.SaveChanges();
            }
        }
    }
}
