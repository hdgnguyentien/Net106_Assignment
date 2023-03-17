using _2.Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.Configurations
{
    public class MonAnConfiguration : IEntityTypeConfiguration<MonAn>
    {
        public void Configure(EntityTypeBuilder<MonAn> builder)
        {
            builder.ToTable(nameof(MonAn));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ten).IsRequired();
            builder.Property(x => x.GiaNhap).IsRequired();
            builder.Property(x => x.GiaNhap).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            builder.Property(x => x.AnhMonAn);

            builder.Property(x => x.IdLoai).IsRequired();

            builder.HasOne(x=>x.loai).WithMany(x=>x.monAns).HasForeignKey(x=>x.IdLoai);
        }
    }
}
