namespace BelajarCRUDWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editTable5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Supplier", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_Supplier", "Password");
        }
    }
}
