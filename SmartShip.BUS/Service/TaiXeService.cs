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
        public Taixe GetByTaiKhoan(string maTaiKhoan)
        {
            var result = (from tx in db.Taixes
                          join nd in db.NguoiDungs on tx.MaNguoiDung equals nd.MaNguoiDung
                          join tk in db.Taikhoans on nd.MaTaiKhoan equals tk.MaTaiKhoan
                          where tk.MaTaiKhoan == maTaiKhoan
                          select tx).FirstOrDefault();

            return result;
        }

        public void Them(Taixe tx)
        {
            db.Taixes.Add(tx);
            db.SaveChanges();
        }
        public void CapNhat(Taixe tx)
        {
            var existing = db.Taixes.Find(tx.MaTaiXe);
            if (existing != null)
            {
                existing.LoaiXe = tx.LoaiXe;
                existing.BienSo = tx.BienSo;
                existing.TongDon = tx.TongDon;
                existing.SanSang = tx.SanSang;
                db.SaveChanges(); // ⚠️ PHẢI CÓ DÒNG NÀY!
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
        public DTO GetThongTinTaiXe(string maTaiXe)
        {
            var result = (from tx in db.Taixes
                          join nd in db.NguoiDungs on tx.MaNguoiDung equals nd.MaNguoiDung
                          where tx.MaTaiXe == maTaiXe
                          select new DTO
                          {
                              HoTen = nd.HoTen,
                              SDT = nd.SDT,
                              BienSo = tx.BienSo
                          }).FirstOrDefault();

            return result;
        }
    }
}
