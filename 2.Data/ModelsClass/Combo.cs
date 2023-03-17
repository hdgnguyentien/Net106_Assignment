using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class Combo
    {
        public Combo() 
        {
            gioHangChiTiets = new HashSet<GioHangChiTiet>();
            hoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        public Guid Id { get; set; }
        public Guid IdMonAn { get; set; }
        public Guid IdDoUong { get; set; }
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public string? AnhCombo { get; set; }
        public MonAn monAn { get; set; }
        public DoUong doUong { get; set; }
        public virtual ICollection<GioHangChiTiet> gioHangChiTiets { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
