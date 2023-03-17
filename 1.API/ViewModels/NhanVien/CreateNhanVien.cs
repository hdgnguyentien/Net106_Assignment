namespace _1.API.ViewModels.NhanVien
{
    public class CreateNhanVien
    {
        public Guid? IdGuiBaoCao { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Sdt { get; set; }
    }
}
