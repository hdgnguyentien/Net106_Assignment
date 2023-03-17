using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class DoUong
    {
        public DoUong()
        {
            combos = new HashSet<Combo>();
            gioHangChiTiets = new HashSet<GioHangChiTiet>();
            hoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public bool TrangThai { get; set; }
        public string? AnhDoUong { get; set; }
        public virtual ICollection<Combo> combos { get; set; }
        public virtual ICollection<GioHangChiTiet> gioHangChiTiets { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
