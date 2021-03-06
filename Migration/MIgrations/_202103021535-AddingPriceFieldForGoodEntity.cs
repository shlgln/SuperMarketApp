using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.MIgrations
{
    [Migration(202103021535)]
    public class _202103021535_AddingPriceFieldForGoodEntity : FluentMigrator.Migration
    {
        public override void Up()
        {
            Alter.Table("Goods").AddColumn("Price").AsInt32().NotNullable().WithDefaultValue(0);
        }
        public override void Down()
        {
            Delete.Column("Price").FromTable("Goods");
        }
    }
}
