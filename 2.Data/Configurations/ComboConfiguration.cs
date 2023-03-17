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
    public class ComboConfiguration : IEntityTypeConfiguration<Combo>
    {
        public void Configure(EntityTypeBuilder<Combo> builder)
        {
            builder.ToTable("Combo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ten).IsRequired();
            builder.Property(x => x.GiaBan).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.IdMonAn).IsRequired();
            builder.Property(x => x.IdDoUong).IsRequired();
            builder.Property(x => x.AnhCombo);

            builder.HasOne(x=>x.monAn).WithMany(x=>x.combos).HasForeignKey(x=>x.IdMonAn);
            builder.HasOne(x=>x.doUong).WithMany(x=>x.combos).HasForeignKey(x=>x.IdDoUong);

        }

    }
}
