namespace LoteAutosGit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIneComprador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compradores", "Ine", c => c.String(nullable: false, maxLength: 64, storeType: "nvarchar"));
            AddColumn("dbo.Usuarios", "status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "status");
            DropColumn("dbo.Compradores", "Ine");
        }
    }
}
