using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To Lambda Expression-----");
            Console.WriteLine();

            //list object creation with person 
            List<Person> list = new List<Person>();

            //method call
            AddingPersonDetails(list);
            SearchPerson(list);
            Console.ReadLine();
        }

        //UC1 person management
        public static void AddingPersonDetails(List<Person> personList) //creating method
        {
            personList.Add(new Person() { SSN = 1, Age = 16, Name = "Ankita", Address = "Pune" });
            personList.Add(new Person() { SSN = 2, Age = 18, Name = "sachin", Address = "Pune" });
            personList.Add(new Person() { SSN = 3, Age = 25, Name = "priya", Address = "Bangalore" });
            personList.Add(new Person() { SSN = 5, Age = 75, Name = "nilima", Address = "pune" });
            personList.Add(new Person() { SSN = 6, Age = 86, Name = "Tina", Address = "Nashik" });
            personList.Add(new Person() { SSN = 7, Age = 15, Name = "anvi", Address = "Hyderabad" });
            
        }

        //UC5 Check for specific name present in list or not
        public static void SearchPerson(List<Person> list)
        {
            try
            {
                var person = list.Where(x => x.Name == "Ankita").First();
                if (person != null)
                {
                    Console.WriteLine("person present");

                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
                else
                {
                    Console.WriteLine("person not exist in a list");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


