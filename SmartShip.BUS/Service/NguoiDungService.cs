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

        public List<NguoiDung> GetAll()
        {
            return db.NguoiDungs.ToList();
        }
        //
        public NguoiDung GetById(string id)
        {
            return db.NguoiDungs.Find(id);
        }

        public void Them(NguoiDung nd)
        {
            db.NguoiDungs.Add(nd);
            db.SaveChanges();
        }

        public void CapNhat(NguoiDung nd)
        {
            var old = db.NguoiDungs.Find(nd.MaNguoiDung);
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(nd);
                db.SaveChanges();
            }
        }

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
