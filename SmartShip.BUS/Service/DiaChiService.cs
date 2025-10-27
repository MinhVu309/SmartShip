using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class DiaChiService
    {
        private Dbcontext db = new Dbcontext();

        public List<DiaChi> GetAll()
        {
            return db.DiaChis.ToList();
        }

        public DiaChi GetById(string id)
        {
            return db.DiaChis.Find(id);
        }

        public List<DiaChi> GetByNguoiDung(string maNguoiDung)
        {
            return db.DiaChis.Where(x => x.MaNguoiDung == maNguoiDung).ToList();
        }

        public void Them(DiaChi dc)
        {
            db.DiaChis.Add(dc);
            db.SaveChanges();
        }

        public void CapNhat(DiaChi dc)
        {
            var old = db.DiaChis.Find(dc.MaDiaChi);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(dc);
                db.SaveChanges();
            }
        }

        public void Xoa(string id)
        {
            var dc = db.DiaChis.Find(id);
            if (dc != null)
            {
                db.DiaChis.Remove(dc);
                db.SaveChanges();
            }
        }
    }
}
