namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usercreationdatetostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "CreatedOn", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
