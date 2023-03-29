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
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F30"),
                    IdLoai = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Ớt ngọt Đà Lạt",
                    SoLuong = 10,
                    GiaBan = 100000,
                    GiaNhap = 80000,
                    LinkAnh = "",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("7CB5F225-8DB2-4D48-9F73-68A42B78C1D2"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Ớt chỉ thiên Hà Nội",
                    SoLuong = 10,
                    GiaBan = 300000,
                    GiaNhap = 280000,
                    LinkAnh = "",
                    TrangThai = true
                });

            modelBuilder.Entity<Loai>().HasData(
                new Loai()
                {
                    Id = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Ớt chỉ thiên",
                    TrangThai = true
                },
                new Loai()
                {
                    Id = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Ớt ngọt",
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
                Sdt = "0987654322",
                IdChucVu = new Guid("26C5F722-3BAA-4DF7-B473-2374B39E02A2"),
                AnhNhanVien = ""
            },
            new NhanVien()
            {
                Id = new Guid("B764E8B0-FE90-42C5-95D3-B854620D274B"),
                Ten = "nga",
                Email = "nga@gmail.com",
                MatKhau = "123456",
                DiaChi = "hn",
                GioiTinh = false,
                Sdt = "0987654323",
                IdChucVu = new Guid("6FC0F38F-B421-4FEF-8361-8136825AA354"),
                AnhNhanVien = ""
            });
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu()
                {
                    Id = new Guid("6FC0F38F-B421-4FEF-8361-8136825AA354"),
                    Ten = "Nhân Viên"
                },
                new ChucVu()
                {
                    Id = new Guid("26C5F722-3BAA-4DF7-B473-2374B39E02A2"),
                    Ten = "Quản lý"
                });
        }
    }
}
