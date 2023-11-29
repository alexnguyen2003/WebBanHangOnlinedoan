namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table_Review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Review",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        FullName = c.String(),
                        Email = c.String(),
                        Content = c.String(),
                        Rate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_Review");
        }
    }
}
