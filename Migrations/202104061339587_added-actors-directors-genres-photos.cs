namespace doge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedactorsdirectorsgenresphotos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Country = c.String(maxLength: 30),
                        PhotoUrl = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateofDeath = c.DateTime(),
                        Email = c.String(),
                        Salary = c.Double(),
                    })
                .PrimaryKey(t => t.ActorId);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Country = c.String(maxLength: 30),
                        PhotoUrl = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateofDeath = c.DateTime(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DirectorId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GTitle = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.PhotoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Photos");
            DropTable("dbo.Genres");
            DropTable("dbo.Directors");
            DropTable("dbo.Actors");
        }
    }
}
