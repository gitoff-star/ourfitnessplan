namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "image_path", c => c.String());
            AlterColumn("dbo.users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.users", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "Email", c => c.String());
            AlterColumn("dbo.users", "Name", c => c.String());
            DropColumn("dbo.users", "image_path");
        }
    }
}
