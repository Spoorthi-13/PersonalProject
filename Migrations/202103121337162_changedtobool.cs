﻿namespace ShoppingProjectA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtobool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RequestTables", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RequestTables", "Status", c => c.String());
        }
    }
}
