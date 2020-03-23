namespace BelajarCRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMyContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Supplier", t => t.Supplier_Id)
                .Index(t => t.Supplier_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Role", "Supplier_Id", "dbo.TB_M_Supplier");
            DropIndex("dbo.TB_M_Role", new[] { "Supplier_Id" });
            DropTable("dbo.TB_M_Role");
        }
    }
}
