using _2.Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Combo>().HasData(
                new Combo()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F30"),
                    IdMonAn = new Guid("008E2497-081B-4E33-8781-5004EDFDF479"),
                    IdDoUong = new Guid("A6640BFB-EE82-45F9-8111-0FFFB4E06A6A"),
                    Ten = "Combo Hạnh Phúc",
                    SoLuong = 10,
                    GiaBan = 100000,
                    AnhCombo = null
                },
                new Combo()
                {
                    Id = new Guid("0B061962-0E18-469B-A59E-7435BAE36DED"),
                    IdMonAn = new Guid("7E9FE1CF-11CF-4FF1-9BFF-B5DEA3803B82"),
                    IdDoUong = new Guid("3CB233CB-A774-4C65-993E-F36AF6BA178E"),
                    Ten = "Combo Không Hạnh Phúc",
                    SoLuong = 10,
                    GiaBan = 200000,
                    AnhCombo = null
                },
                new Combo()
                {
                    Id = new Guid("7CB5F225-8DB2-4D48-9F73-68A42B78C1D2"),
                    IdMonAn = new Guid("E7DBF7D6-95D0-4294-B801-F63BC610A746"),
                    IdDoUong = new Guid("68BA1DDF-46B0-4D88-987B-E1D0852EF1C7"),
                    Ten = "Combo Rất Hạnh Phúc",
                    SoLuong = 10,
                    GiaBan = 300000,
                    AnhCombo = null
                });

            modelBuilder.Entity<DoUong>().HasData(
                new DoUong()
                {
                    Id = new Guid("A6640BFB-EE82-45F9-8111-0FFFB4E06A6A"),
                    Ten = "Coca",
                    SoLuong = 10,
                    GiaNhap = 12000,
                    GiaBan = 15000,
                    TrangThai = true,
                    AnhDoUong = null
                },
                new DoUong()
                {
                    Id = new Guid("3CB233CB-A774-4C65-993E-F36AF6BA178E"),
                    Ten = "Pepsi",
                    SoLuong = 10,
                    GiaNhap = 10000,
                    GiaBan = 12000,
                    TrangThai = true,
                    AnhDoUong = null
                },
                new DoUong()
                {
                    Id = new Guid("68BA1DDF-46B0-4D88-987B-E1D0852EF1C7"),
                    Ten = "Nước Lọc",
                    SoLuong = 10,
                    GiaNhap = 7000,
                    GiaBan = 10000,
                    TrangThai = true,
                    AnhDoUong = null
                });
            modelBuilder.Entity<MonAn>().HasData(
                new MonAn()
                {
                    Id = new Guid("008E2497-081B-4E33-8781-5004EDFDF479"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Pizza Bò",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                },
                new MonAn()
                {
                    Id = new Guid("7E9FE1CF-11CF-4FF1-9BFF-B5DEA3803B82"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Pizza Lợn",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                },
                new MonAn()
                {
                    Id = new Guid("E7DBF7D6-95D0-4294-B801-F63BC610A746"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Pizza Xúc Xích",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                },
                new MonAn()
                {
                    Id = new Guid("52C4A9D4-75EC-4D96-A046-BCA3A3831B3A"),
                    IdLoai = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Xà lách trộn bò",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                },
                new MonAn()
                {
                    Id = new Guid("11D8D7F4-318E-4209-9605-04B1260E008C"),
                    IdLoai = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Xà lách trộn lợn",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                },
                new MonAn()
                {
                    Id = new Guid("D6776C14-9F11-4A94-A525-E826D96C6C2E"),
                    IdLoai = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Xà lách trộn xúc xích",
                    GiaNhap = 70000,
                    GiaBan = 100000,
                    SoLuong = 15,
                    TrangThai = true,
                    AnhMonAn = null
                });
            modelBuilder.Entity<Loai>().HasData(
                new Loai()
                {
                    Id = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Pizza",
                    TrangThai = true
                },
                new Loai()
                {
                    Id = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Xà lách",
                    TrangThai = true
                });
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang()
                {
                    Id = new Guid("9FD94A59-1AB2-4EAE-9654-767481E96BFE"),
                    Ten = "A",
                    Email = "tienncph18949@fpt.edu.vn",
                    MatKhau = "123456",
                    DiaChi = "a",
                    GioiTinh = true,
                    Sdt = "0987654321"
                });
            modelBuilder.Entity<GioHang>().HasData(
                new GioHang()
                {
                    Id = new Guid("4F7B6227-FD02-407A-8191-604739739697"),
                    IdKhachHang = new Guid("9FD94A59-1AB2-4EAE-9654-767481E96BFE")
                });
            modelBuilder.Entity<NhanVien>().HasData(
            new NhanVien()
            {
                Id = new Guid("B54E5B6D-2309-4844-99F6-50B18F665440"),
                Ten = "tien",
                Email = "hdgnguyentien@gmail.com",
                MatKhau = "123456",
                DiaChi = "hd",
                GioiTinh = true,
                Sdt = "0987654322"
            });
        }
    }
}
