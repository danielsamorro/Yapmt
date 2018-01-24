namespace Yapmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompleteStatusToTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Completed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Completed");
        }
    }
}
