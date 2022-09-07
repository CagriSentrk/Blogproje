namespace Bloglarproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKullanici : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        kullanici = c.String(),
                        sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicis");
        }
    }
}
