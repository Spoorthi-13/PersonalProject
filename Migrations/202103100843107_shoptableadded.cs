﻿namespace ShoppingProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shoptableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopName = c.String(nullable: false),
                        BusinessCategory = c.String(nullable: false),
                        NoOfEmployees = c.Int(nullable: false),
                        WorkingHrs = c.Int(nullable: false),
                        Holiday = c.String(),
                        LicenseNo = c.String(nullable: false),
                        LicenseExpiry = c.DateTime(nullable: false),
                        ShopOwnerName = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shops");
        }
    }
}
