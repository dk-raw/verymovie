namespace doge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMovieProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Double(nullable: false));
            AddColumn("dbo.Movies", "Country", c => c.String(maxLength: 30));
            AddColumn("dbo.Movies", "ProductionYear", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Duration", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "PhotoUrl", c => c.String());
            AddColumn("dbo.Movies", "TrailerUrl", c => c.String());
            AddColumn("dbo.Movies", "Price", c => c.Double());
            AddColumn("dbo.Movies", "Viewed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "Viewed");
            DropColumn("dbo.Movies", "Price");
            DropColumn("dbo.Movies", "TrailerUrl");
            DropColumn("dbo.Movies", "PhotoUrl");
            DropColumn("dbo.Movies", "Duration");
            DropColumn("dbo.Movies", "ProductionYear");
            DropColumn("dbo.Movies", "Country");
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
