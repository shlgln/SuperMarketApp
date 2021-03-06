using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Models.Entities;
using System;

namespace SuperMarket.Models.EntityMapConfig
{
    public class SalesFactorEntityMap : IEntityTypeConfiguration<GetSalesFactorDtors>
    {
        public void Configure(EntityTypeBuilder<GetSalesFactorDtors> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.GoodCode)
                .HasMaxLength(10).IsRequired();

            builder.Property(_ => _.SalesDate)
                .HasColumnType<DateTime>("datetime");

            builder.Property(_ => _.GoodCount).IsRequired();
        }
    }
}
