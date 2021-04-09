using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); //In the Main() method, create a list of at least 10 employees
            employees.Add(new Employee("Breanna", "Starika", 22)); 
            employees.Add(new Employee("Joe", "Gatto", 2));
            employees.Add(new Employee("Rigory", "Ricardo", 24));
            employees.Add(new Employee("Enrique", "Hero", 3));
            employees.Add(new Employee("Pork", "Chop", 25));
            employees.Add(new Employee("Nick", "Clause", 26));
            employees.Add(new Employee("Joe", "Shmoe", 27));
            employees.Add(new Employee("Okja", "Ja", 1));
            employees.Add(new Employee("William", "Shapessphere", 29));
            employees.Add(new Employee("Arnold", "Shwartzspear", 30));

            List<Employee> joeList = new List<Employee>();

            foreach (Employee joe in employees) //Using a foreach loop, create a new list of all employees with the first name “Joe”
            {
                if (joe.FirstName.Equals ("Joe"))
                {
                    joeList.Add(joe);
                }
            }
            List<Employee> newJoe = employees.Where(x => x.FirstName == "Joe").ToList(); //with a lambda expression, create a new list of all employees with the first name "Joe"

            List<Employee> newList = employees.Where(x => x.Id >= 5).ToList(); //Using a lambda expression, make a list of all employees with an Id number greater than 5
            Console.WriteLine(joeList.Count); //display how many employees with first name joe were added to joelist
            Console.WriteLine(newList.Count); //display how many employees with Id greater than 5 to newlist
            Console.ReadLine();

            //Employee n = new Employee(); // instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
            //n.FirstName = "Sample";
            //n.LastName = "Student";

            //n.SayName(); //Call the superclass method SayName() on the Employee object
            //Console.ReadLine();

            //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
            //Employee e = new Employee();
            //Employee b = new Employee();

            //int eId = 34; //use the newly overloaded == operator to compare two Employee objects by their Id
            //int eId2 = 45;

            //bool same = false;

            //e.Id = eId;
            //b.Id = eId2;

            //same = e == b;
            //Console.WriteLine(same);
            //Console.ReadLine();


        }
    }
}
