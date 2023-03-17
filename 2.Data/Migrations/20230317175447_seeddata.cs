using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DoUong",
                columns: new[] { "Id", "AnhDoUong", "GiaBan", "GiaNhap", "SoLuong", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("3cb233cb-a774-4c65-993e-f36af6ba178e"), null, 12000m, 10000m, 10, "Pepsi", true },
                    { new Guid("68ba1ddf-46b0-4d88-987b-e1d0852ef1c7"), null, 10000m, 7000m, 10, "Nước Lọc", true },
                    { new Guid("a6640bfb-ee82-45f9-8111-0fffb4e06a6a"), null, 15000m, 12000m, 10, "Coca", true }
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
                    { new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), "Xà lách", true },
                    { new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "Pizza", true }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdGuiBaoCao", "IdGuiBcNavigationId", "MatKhau", "Sdt", "Ten" },
                values: new object[] { new Guid("b54e5b6d-2309-4844-99f6-50b18f665440"), "hd", "hdgnguyentien@gmail.com", true, null, null, "123456", "0987654322", "tien" });

            migrationBuilder.InsertData(
                table: "GioHang",
                columns: new[] { "Id", "IdKhachHang" },
                values: new object[] { new Guid("4f7b6227-fd02-407a-8191-604739739697"), new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe") });

            migrationBuilder.InsertData(
                table: "MonAn",
                columns: new[] { "Id", "AnhMonAn", "GiaBan", "GiaNhap", "IdLoai", "SoLuong", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("008e2497-081b-4e33-8781-5004edfdf479"), null, 100000m, 70000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), 15, "Pizza Bò", true },
                    { new Guid("11d8d7f4-318e-4209-9605-04b1260e008c"), null, 100000m, 70000m, new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), 15, "Xà lách trộn lợn", true },
                    { new Guid("52c4a9d4-75ec-4d96-a046-bca3a3831b3a"), null, 100000m, 70000m, new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), 15, "Xà lách trộn bò", true },
                    { new Guid("7e9fe1cf-11cf-4ff1-9bff-b5dea3803b82"), null, 100000m, 70000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), 15, "Pizza Lợn", true },
                    { new Guid("d6776c14-9f11-4a94-a525-e826d96c6c2e"), null, 100000m, 70000m, new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), 15, "Xà lách trộn xúc xích", true },
                    { new Guid("e7dbf7d6-95d0-4294-b801-f63bc610a746"), null, 100000m, 70000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), 15, "Pizza Xúc Xích", true }
                });

            migrationBuilder.InsertData(
                table: "Combo",
                columns: new[] { "Id", "AnhCombo", "GiaBan", "IdDoUong", "IdMonAn", "SoLuong", "Ten" },
                values: new object[] { new Guid("0b061962-0e18-469b-a59e-7435bae36ded"), null, 200000m, new Guid("3cb233cb-a774-4c65-993e-f36af6ba178e"), new Guid("7e9fe1cf-11cf-4ff1-9bff-b5dea3803b82"), 10, "Combo Không Hạnh Phúc" });

            migrationBuilder.InsertData(
                table: "Combo",
                columns: new[] { "Id", "AnhCombo", "GiaBan", "IdDoUong", "IdMonAn", "SoLuong", "Ten" },
                values: new object[] { new Guid("7cb5f225-8db2-4d48-9f73-68a42b78c1d2"), null, 300000m, new Guid("68ba1ddf-46b0-4d88-987b-e1d0852ef1c7"), new Guid("e7dbf7d6-95d0-4294-b801-f63bc610a746"), 10, "Combo Rất Hạnh Phúc" });

            migrationBuilder.InsertData(
                table: "Combo",
                columns: new[] { "Id", "AnhCombo", "GiaBan", "IdDoUong", "IdMonAn", "SoLuong", "Ten" },
                values: new object[] { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f30"), null, 100000m, new Guid("a6640bfb-ee82-45f9-8111-0fffb4e06a6a"), new Guid("008e2497-081b-4e33-8781-5004edfdf479"), 10, "Combo Hạnh Phúc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Combo",
                keyColumn: "Id",
                keyValue: new Guid("0b061962-0e18-469b-a59e-7435bae36ded"));

            migrationBuilder.DeleteData(
                table: "Combo",
                keyColumn: "Id",
                keyValue: new Guid("7cb5f225-8db2-4d48-9f73-68a42b78c1d2"));

            migrationBuilder.DeleteData(
                table: "Combo",
                keyColumn: "Id",
                keyValue: new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f30"));

            migrationBuilder.DeleteData(
                table: "GioHang",
                keyColumn: "Id",
                keyValue: new Guid("4f7b6227-fd02-407a-8191-604739739697"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("11d8d7f4-318e-4209-9605-04b1260e008c"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("52c4a9d4-75ec-4d96-a046-bca3a3831b3a"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("d6776c14-9f11-4a94-a525-e826d96c6c2e"));

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: new Guid("b54e5b6d-2309-4844-99f6-50b18f665440"));

            migrationBuilder.DeleteData(
                table: "DoUong",
                keyColumn: "Id",
                keyValue: new Guid("3cb233cb-a774-4c65-993e-f36af6ba178e"));

            migrationBuilder.DeleteData(
                table: "DoUong",
                keyColumn: "Id",
                keyValue: new Guid("68ba1ddf-46b0-4d88-987b-e1d0852ef1c7"));

            migrationBuilder.DeleteData(
                table: "DoUong",
                keyColumn: "Id",
                keyValue: new Guid("a6640bfb-ee82-45f9-8111-0fffb4e06a6a"));

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "Id",
                keyValue: new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe"));

            migrationBuilder.DeleteData(
                table: "Loai",
                keyColumn: "Id",
                keyValue: new Guid("22516479-1dfe-4780-b8e0-85c885882aff"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("008e2497-081b-4e33-8781-5004edfdf479"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("7e9fe1cf-11cf-4ff1-9bff-b5dea3803b82"));

            migrationBuilder.DeleteData(
                table: "MonAn",
                keyColumn: "Id",
                keyValue: new Guid("e7dbf7d6-95d0-4294-b801-f63bc610a746"));

            migrationBuilder.DeleteData(
                table: "Loai",
                keyColumn: "Id",
                keyValue: new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"));
        }
    }
}
