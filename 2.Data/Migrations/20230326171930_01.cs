using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2.Data.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGuiBaoCao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    IdGuiBcNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_IdGuiBcNavigationId",
                        column: x => x.IdGuiBcNavigationId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_Loai_IdLoai",
                        column: x => x.IdLoai,
                        principalTable: "Loai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "Ten" },
                values: new object[,]
                {
                    { new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"), "Quản lý" },
                    { new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"), "Nhân Viên" }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "MatKhau", "Sdt", "Ten" },
                values: new object[] { new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe"), "a", "tienncph18949@fpt.edu.vn", true, "123456", "0987654321", "A" });

            migrationBuilder.InsertData(
                table: "Loai",
                columns: new[] { "Id", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), "Ớt ngọt", true },
                    { new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "Ớt chỉ thiên", true }
                });

            migrationBuilder.InsertData(
                table: "GioHang",
                columns: new[] { "Id", "IdKhachHang" },
                values: new object[] { new Guid("4f7b6227-fd02-407a-8191-604739739697"), new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe") });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "AnhNhanVien", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdGuiBaoCao", "IdGuiBcNavigationId", "MatKhau", "Sdt", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("b54e5b6d-2309-4844-99f6-50b18f665440"), "", "hd", "hdgnguyentien@gmail.com", true, new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"), null, null, "123456", "0987654322", "tien", false },
                    { new Guid("b764e8b0-fe90-42c5-95d3-b854620d274b"), "", "hn", "nga@gmail.com", false, new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"), null, null, "123456", "0987654323", "nga", false }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdLoai", "LinkAnh", "SoLuong", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("7cb5f225-8db2-4d48-9f73-68a42b78c1d2"), 300000m, 280000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "", 10, "Ớt chỉ thiên Hà Nội", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f30"), 100000m, 80000m, new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), "", 10, "Ớt ngọt Đà Lạt", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdGioHang",
                table: "GioHangChiTiet",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdSanPham",
                table: "GioHangChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdSanPham",
                table: "HoaDonChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdGuiBcNavigationId",
                table: "NhanVien",
                column: "IdGuiBcNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdLoai",
                table: "SanPham",
                column: "IdLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
