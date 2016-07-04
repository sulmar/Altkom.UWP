namespace Altkom.Bicycle.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Model = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Image = c.Binary(),
                        Station_StationId = c.Int(),
                    })
                .PrimaryKey(t => t.BikeId)
                .ForeignKey("dbo.Stations", t => t.Station_StationId)
                .Index(t => t.Station_StationId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationId = c.Int(nullable: false, identity: true),
                        StationName = c.String(),
                        Address = c.String(),
                        Location_Latitude = c.Double(nullable: false),
                        Location_Longitude = c.Double(nullable: false),
                        Location_Altitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StationId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalId = c.Int(nullable: false, identity: true),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        BeginStation_StationId = c.Int(),
                        Bike_BikeId = c.Int(),
                        EndStation_StationId = c.Int(),
                        Rentee_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.RentalId)
                .ForeignKey("dbo.Stations", t => t.BeginStation_StationId)
                .ForeignKey("dbo.Bikes", t => t.Bike_BikeId)
                .ForeignKey("dbo.Stations", t => t.EndStation_StationId)
                .ForeignKey("dbo.People", t => t.Rentee_PersonId)
                .Index(t => t.BeginStation_StationId)
                .Index(t => t.Bike_BikeId)
                .Index(t => t.EndStation_StationId)
                .Index(t => t.Rentee_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Rentee_PersonId", "dbo.People");
            DropForeignKey("dbo.Rentals", "EndStation_StationId", "dbo.Stations");
            DropForeignKey("dbo.Rentals", "Bike_BikeId", "dbo.Bikes");
            DropForeignKey("dbo.Rentals", "BeginStation_StationId", "dbo.Stations");
            DropForeignKey("dbo.Bikes", "Station_StationId", "dbo.Stations");
            DropIndex("dbo.Rentals", new[] { "Rentee_PersonId" });
            DropIndex("dbo.Rentals", new[] { "EndStation_StationId" });
            DropIndex("dbo.Rentals", new[] { "Bike_BikeId" });
            DropIndex("dbo.Rentals", new[] { "BeginStation_StationId" });
            DropIndex("dbo.Bikes", new[] { "Station_StationId" });
            DropTable("dbo.Rentals");
            DropTable("dbo.People");
            DropTable("dbo.Stations");
            DropTable("dbo.Bikes");
        }
    }
}
