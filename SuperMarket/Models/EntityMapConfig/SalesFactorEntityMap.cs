using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Models.EntityMapConfig
{
    public class SalesFactorEntityMap : IEntityTypeConfiguration<SaleFactors>
    {
        public void Configure(EntityTypeBuilder<SaleFactors> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.GoodCode)
                .HasMaxLength(10);

            builder.Property(_ => _.SalesDate).HasColumnType<DateTime>("datetime");
        }
    }
}
