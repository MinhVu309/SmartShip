    using SmartShip.DAL.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BUS.Service
    {
        public class TaiXeService
        {
            private Dbcontext db = new Dbcontext();

            public List<Taixe> GetAll()
            {
                return db.Taixes.ToList();
            }
            //
            public Taixe GetById(string id)
            {
                return db.Taixes.Find(id);
            }

            public Taixe GetByNguoiDung(string maNguoiDung)
            {
                return db.Taixes.FirstOrDefault(x => x.MaNguoiDung == maNguoiDung);
            }

            public void Them(Taixe tx)
            {
                db.Taixes.Add(tx);
                db.SaveChanges();
            }
            public void CapNhat(Taixe tx)
            {
                var old = db.Taixes.Find(tx.MaTaiXe);
                if (old != null)
                {
                    db.Entry(old).CurrentValues.SetValues(tx);
                    db.SaveChanges();
                }
            }

            public void Xoa(string id)
            {
                var tx = db.Taixes.Find(id);
                if (tx != null)
                {
                    db.Taixes.Remove(tx);
                    db.SaveChanges();
                }
            }
        }
    }
