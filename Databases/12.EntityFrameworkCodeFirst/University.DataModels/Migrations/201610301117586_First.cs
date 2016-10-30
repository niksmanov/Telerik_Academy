namespace University.DataModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 30),
                        TimeSent = c.DateTime(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 40),
                        StudentNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_ID = c.Int(nullable: false),
                        Course_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_ID, t.Course_ID })
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_ID, cascadeDelete: true)
                .Index(t => t.Student_ID)
                .Index(t => t.Course_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Homework", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Homework", "CourseID", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "Course_ID" });
            DropIndex("dbo.StudentCourses", new[] { "Student_ID" });
            DropIndex("dbo.Materials", new[] { "CourseID" });
            DropIndex("dbo.Homework", new[] { "CourseID" });
            DropIndex("dbo.Homework", new[] { "StudentID" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Materials");
            DropTable("dbo.Students");
            DropTable("dbo.Homework");
            DropTable("dbo.Courses");
        }
    }
}
