using System;
using System.Collections.Generic;
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
                Console.WriteLine("Are you a freshman, sophomore, junior, senior?");
                var level = (Console.ReadLine());

                var grade = new Grade { gradeLevel = level };
                db.Grades.Add(grade);
                db.SaveChanges();

                var query = from g in db.Grades
                            orderby g.gradeLevel
                            select g;
                foreach (var item in query)
                {
                    Console.WriteLine(item.gradeLevel);
                }
            }
        }
    }
    public class Grade
    {
        public string gradeLevel { get; set; }
        public virtual List<Student> Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public int Id { get; set; }

        public int gradeLevel { get; set; }
        public virtual Grade Grade { get; set; }
    }
    public class GradeContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
