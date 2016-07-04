namespace Altkom.Bicycle.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColorToBike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "Color");
        }
    }
}
