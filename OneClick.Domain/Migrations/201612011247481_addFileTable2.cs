namespace OneClick.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFileTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "FileType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "FileType");
        }
    }
}