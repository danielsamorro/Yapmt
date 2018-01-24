namespace Yapmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredToFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Tasks", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Tasks", "Owner", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Owner", c => c.String());
            AlterColumn("dbo.Tasks", "Description", c => c.String());
            AlterColumn("dbo.Projects", "Name", c => c.String());
        }
    }
}
