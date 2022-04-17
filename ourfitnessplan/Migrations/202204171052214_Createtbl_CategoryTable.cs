namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createtbl_CategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Category",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        category_name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Category");
        }
    }
}
