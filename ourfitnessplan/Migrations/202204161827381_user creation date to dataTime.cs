namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usercreationdatetodataTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "CreatedOn", c => c.String());
        }
    }
}
