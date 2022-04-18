namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reqioredImagecoverchanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_posts", "CoverImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_posts", "CoverImage", c => c.String(nullable: false));
        }
    }
}
