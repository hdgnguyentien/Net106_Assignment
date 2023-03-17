namespace _1.API.ViewModels.MonAn
{
    public class UpdateMonAn
    {
        public Guid IdLoai { get; set; }
        public string Ten { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public string? AnhMonAn { get; set; }
    }
}
