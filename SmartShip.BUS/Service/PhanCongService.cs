using SmartShip.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class PhanCongService
    {
        private Dbcontext db = new Dbcontext();

        public List<PhanCong> GetAll()
        {
            return db.PhanCongs.ToList();
        }

        public PhanCong GetById(string id)
        {
            return db.PhanCongs.Find(id);
        }

        public List<PhanCong> GetByTaiXe(string maTaiXe)
        {
            return db.PhanCongs.Where(x => x.MaTaiXe == maTaiXe).ToList();
        }

        public void Them(PhanCong pc)
        {
            db.PhanCongs.Add(pc);
            db.SaveChanges();
        }

        public void CapNhat(PhanCong pc)
        {
            var old = db.PhanCongs.Find(pc.MaPhanCong);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(pc);
                db.SaveChanges();
            }
        }

        public void Xoa(string id)
        {
            var pc = db.PhanCongs.Find(id);
            if (pc != null)
            {
                db.PhanCongs.Remove(pc);
                db.SaveChanges();
            }
        }
    }
}
