namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createtbl_postsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        blogid = c.String(),
                        title = c.String(),
                        content = c.String(),
                        tags = c.String(),
                        aurthor = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        lastUpdated = c.DateTime(nullable: false),
                        deleteStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_posts");
        }
    }
}
