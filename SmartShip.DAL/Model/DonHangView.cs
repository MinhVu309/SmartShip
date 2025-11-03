using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShip.DAL.Model
{
    public  class DonHangView
    {
        public string MaDon { get; set; }
        public string KhachHang { get; set; }
        public string DiaChi { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public bool DaGiao { get; set; }
    }
}
