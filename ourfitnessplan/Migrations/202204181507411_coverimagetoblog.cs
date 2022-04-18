namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coverimagetoblog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_posts", "CoverImage", c => c.String(nullable: false));
            AlterColumn("dbo.tbl_posts", "title", c => c.String(nullable: false));
            AlterColumn("dbo.tbl_posts", "content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_posts", "content", c => c.String());
            AlterColumn("dbo.tbl_posts", "title", c => c.String());
            DropColumn("dbo.tbl_posts", "CoverImage");
        }
    }
}
