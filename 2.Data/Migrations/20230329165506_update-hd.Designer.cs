﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2.Data.DbContexts;

#nullable disable

namespace _2.Data.Migrations
{
    [DbContext(typeof(DoAnNhanhDbContext))]
    [Migration("20230329165506_update-hd")]
    partial class updatehd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2.Data.ModelsClass.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVu", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"),
                            Ten = "Nhân Viên"
                        },
                        new
                        {
                            Id = new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"),
                            Ten = "Quản lý"
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("GioHang", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f7b6227-fd02-407a-8191-604739739697"),
                            IdKhachHang = new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe")
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGioHang");

                    b.HasIndex("IdSanPham");

                    b.ToTable("GioHangChiTiet", (string)null);
                });

            modelBuilder.Entity("_2.Data.ModelsClass.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdKhachHang")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHoaDon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayTao")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("TrangThai")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("_2.Data.ModelsClass.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdSanPham");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_2.Data.ModelsClass.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe"),
                            DiaChi = "a",
                            Email = "tienncph18949@fpt.edu.vn",
                            GioiTinh = true,
                            MatKhau = "123456",
                            Sdt = "0987654321",
                            Ten = "A"
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.Loai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Loai", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"),
                            Ten = "Ớt chỉ thiên",
                            TrangThai = true
                        },
                        new
                        {
                            Id = new Guid("22516479-1dfe-4780-b8e0-85c885882aff"),
                            Ten = "Ớt ngọt",
                            TrangThai = true
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnhNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<Guid?>("IdChucVu")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGuiBaoCao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGuiBcNavigationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.HasIndex("IdGuiBcNavigationId");

                    b.ToTable("NhanVien", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b54e5b6d-2309-4844-99f6-50b18f665440"),
                            AnhNhanVien = "",
                            DiaChi = "hd",
                            Email = "hdgnguyentien@gmail.com",
                            GioiTinh = true,
                            IdChucVu = new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"),
                            MatKhau = "123456",
                            Sdt = "0987654322",
                            Ten = "tien",
                            TrangThai = false
                        },
                        new
                        {
                            Id = new Guid("b764e8b0-fe90-42c5-95d3-b854620d274b"),
                            AnhNhanVien = "",
                            DiaChi = "hn",
                            Email = "nga@gmail.com",
                            GioiTinh = false,
                            IdChucVu = new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"),
                            MatKhau = "123456",
                            Sdt = "0987654323",
                            Ten = "nga",
                            TrangThai = false
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdLoai")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdLoai");

                    b.ToTable("SanPham", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f30"),
                            GiaBan = 100000m,
                            GiaNhap = 80000m,
                            IdLoai = new Guid("22516479-1dfe-4780-b8e0-85c885882aff"),
                            LinkAnh = "",
                            SoLuong = 10,
                            Ten = "Ớt ngọt Đà Lạt",
                            TrangThai = true
                        },
                        new
                        {
                            Id = new Guid("7cb5f225-8db2-4d48-9f73-68a42b78c1d2"),
                            GiaBan = 300000m,
                            GiaNhap = 280000m,
                            IdLoai = new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"),
                            LinkAnh = "",
                            SoLuong = 10,
                            Ten = "Ớt chỉ thiên Hà Nội",
                            TrangThai = true
                        });
                });

            modelBuilder.Entity("_2.Data.ModelsClass.GioHang", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.KhachHang", "khachHang")
                        .WithMany("gioHangs")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHang");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.GioHangChiTiet", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.GioHang", "gioHang")
                        .WithMany("gioHangChiTiets")
                        .HasForeignKey("IdGioHang");

                    b.HasOne("_2.Data.ModelsClass.SanPham", "sanpham")
                        .WithMany("gioHangChiTiets")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("gioHang");

                    b.Navigation("sanpham");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.HoaDon", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.KhachHang", "khachHang")
                        .WithMany("hoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2.Data.ModelsClass.NhanVien", "nhanVien")
                        .WithMany("hoaDons")
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("khachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.HoaDonChiTiet", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.HoaDon", "hoaDon")
                        .WithMany("hoaDonChiTiets")
                        .HasForeignKey("IdHoaDon");

                    b.HasOne("_2.Data.ModelsClass.SanPham", "sanpham")
                        .WithMany("hoaDonChiTiets")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("hoaDon");

                    b.Navigation("sanpham");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.NhanVien", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.ChucVu", "chucVu")
                        .WithMany("nhanViens")
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_2.Data.ModelsClass.NhanVien", "IdGuiBcNavigation")
                        .WithMany("InverseIdGuiBcNavigation")
                        .HasForeignKey("IdGuiBcNavigationId");

                    b.Navigation("IdGuiBcNavigation");

                    b.Navigation("chucVu");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.SanPham", b =>
                {
                    b.HasOne("_2.Data.ModelsClass.Loai", "loai")
                        .WithMany("sanPhams")
                        .HasForeignKey("IdLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loai");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.ChucVu", b =>
                {
                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.GioHang", b =>
                {
                    b.Navigation("gioHangChiTiets");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.HoaDon", b =>
                {
                    b.Navigation("hoaDonChiTiets");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.KhachHang", b =>
                {
                    b.Navigation("gioHangs");

                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.Loai", b =>
                {
                    b.Navigation("sanPhams");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.NhanVien", b =>
                {
                    b.Navigation("InverseIdGuiBcNavigation");

                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("_2.Data.ModelsClass.SanPham", b =>
                {
                    b.Navigation("gioHangChiTiets");

                    b.Navigation("hoaDonChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
