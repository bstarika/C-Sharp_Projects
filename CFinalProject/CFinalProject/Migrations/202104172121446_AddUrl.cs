﻿namespace CFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        gradeLevel = c.String(nullable: false, maxLength: 128),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.gradeLevel);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GPA = c.Double(nullable: false),
                        gradeLevel = c.Int(nullable: false),
                        Grade_gradeLevel = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.Grade_gradeLevel)
                .Index(t => t.Grade_gradeLevel);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Grade_gradeLevel", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_gradeLevel" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
