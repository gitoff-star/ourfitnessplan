namespace ourfitnessplan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateusersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Confirm_password = c.String(),
                        User_status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
