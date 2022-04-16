namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usercreationdateadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "CreatedOn");
        }
    }
}
