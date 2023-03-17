using _2.Data.Configurations;
using _2.Data.Extensions;
using _2.Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.DbContexts
{
    public class DoAnNhanhDbContext : DbContext
    {
        public DoAnNhanhDbContext() { }
        public DoAnNhanhDbContext(DbContextOptions<DoAnNhanhDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=HDGNGUYENTIEN\\SQLEXPRESS;Database=Net106Database;Trusted_Connection=True;"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ComboConfiguration());
            modelBuilder.ApplyConfiguration(new DoUongConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiConfiguration());
            modelBuilder.ApplyConfiguration(new MonAnConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());

            modelBuilder.Seed();
        }
        //dbset
        public DbSet<Combo> Combos { get; set; }
        public DbSet<DoUong> DoUongs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
    }
}
