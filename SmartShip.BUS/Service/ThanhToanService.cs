using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ThanhToanService
    {
        private Dbcontext db = new Dbcontext();

        public List<ThanhToan> GetAll()
        {
            return db.ThanhToans.ToList();
        }

        public ThanhToan GetById(string id)
        {
            return db.ThanhToans.Find(id);
        }

        public List<ThanhToan> GetByDon(string maDon)
        {
            return db.ThanhToans.Where(x => x.MaDon == maDon).ToList();
        }

        public void Them(ThanhToan tt)
        {
            db.ThanhToans.Add(tt);
            db.SaveChanges();
        }

        public void CapNhat(ThanhToan tt)
        {
            var old = db.ThanhToans.Find(tt.MaThanhToan);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(tt);
                db.SaveChanges();
            }
        }

        public void Xoa(string id)
        {
            var tt = db.ThanhToans.Find(id);
            if (tt != null)
            {
                db.ThanhToans.Remove(tt);
                db.SaveChanges();
            }
        }
    }
}
