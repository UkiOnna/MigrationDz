namespace MigrationDz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeAndNickname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Nickname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Nickname");
            DropColumn("dbo.People", "Age");
        }
    }
}
