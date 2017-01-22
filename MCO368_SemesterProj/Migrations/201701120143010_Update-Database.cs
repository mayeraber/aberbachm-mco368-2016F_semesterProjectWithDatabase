namespace MCO368_SemesterProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Produc_ProdName", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Produc_ProdName" });
            AddColumn("dbo.Purchases", "User_Username", c => c.String(maxLength: 128));
            AddColumn("dbo.Users", "Password", c => c.String());
            CreateIndex("dbo.Purchases", "User_Username");
            AddForeignKey("dbo.Purchases", "User_Username", "dbo.Users", "Username");
            DropColumn("dbo.Products", "Produc_ProdName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Produc_ProdName", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Purchases", "User_Username", "dbo.Users");
            DropIndex("dbo.Purchases", new[] { "User_Username" });
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Purchases", "User_Username");
            CreateIndex("dbo.Products", "Produc_ProdName");
            AddForeignKey("dbo.Products", "Produc_ProdName", "dbo.Products", "ProdName");
        }
    }
}
