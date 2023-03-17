using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class NhanVien
    {
        public NhanVien() 
        {
            hoaDons = new HashSet<HoaDon>();
            InverseIdGuiBcNavigation = new HashSet<NhanVien>();
        }
        public Guid Id { get; set; }
        public Guid? IdGuiBaoCao { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Sdt { get; set; }
        public virtual NhanVien? IdGuiBcNavigation { get; set; }
        public virtual ICollection<HoaDon> hoaDons { get; set; }
        public virtual ICollection<NhanVien> InverseIdGuiBcNavigation { get; set; }
    }
}
