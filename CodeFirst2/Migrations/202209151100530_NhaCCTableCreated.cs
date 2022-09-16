namespace CodeFirst2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhaCCTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCCs",
                c => new
                    {
                        IDNCC = c.Int(nullable: false, identity: true),
                        TenNCC = c.String(nullable: false),
                        TenGiaoDich = c.String(nullable: false),
                        SDT = c.Int(nullable: false),
                        fax = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IDNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCCs");
        }
    }
}
