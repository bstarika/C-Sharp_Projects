using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GradeContext())
            {
                //create and save a new grade level for student
                Console.WriteLine("Are you a freshman, sophomore, junior, senior?");
                var level = (Console.ReadLine());

                var grade = new Grade { gradeLevel = level };
                db.Grades.Add(grade);
                db.SaveChanges();

                var stud = new Student { Name = "Breanna", GPA = 3.4, Id = 22, gradeLevel = level };
                db.Students.Add(stud);
                db.SaveChanges();

                
                //display all grade levels in database
                //var query = from g in db.Grades
                //            orderby g.gradeLevel
                //            select g;
                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.gradeLevel);
                //}
                Console.WriteLine("Press any key to exit....");
                Console.ReadKey();
            }
        }
    }
    public class Grade
    {
        [Key]
        public string gradeLevel { get; set; }
        public string Url { get; set; }

        public virtual List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public int Id { get; set; }

        public string gradeLevel { get; set; }
        public virtual Grade Grade { get; set; }
    }
    public class GradeContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
