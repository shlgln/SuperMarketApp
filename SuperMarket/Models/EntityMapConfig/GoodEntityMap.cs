using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Models.Entities;

namespace SuperMarket.Models.EntityMapConfig
{
    public class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Id).ValueGeneratedOnAdd();

            builder.HasOne(_ => _.Category)
                .WithMany(_ => _.Goods)
                .HasForeignKey(_ => _.CategoryId);
        }
    }
}
