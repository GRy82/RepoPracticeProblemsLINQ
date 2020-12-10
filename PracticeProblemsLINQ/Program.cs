using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            words = LinqProblems.RunProblem1(words);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            names = LinqProblems.RunProblem2(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
                {
                    new Customer(1, "Mike", "Rodgers"),
                    new Customer(2, "Nick", "Allen"),
                    new Customer(3, "Jason", "Ryan"),
                    new Customer(4, "Dan", "Laffey")
                };
            Customer mike = LinqProblems.RunProblem3(customers);
            Console.WriteLine(mike.FirstName);
            Console.WriteLine();

            Customer customer3 = LinqProblems.RunProblem4(customers);
            Console.WriteLine(customer3.FirstName + " " + customer3.LastName);
            Console.WriteLine();


            //problem 5
            List<string> classgrades = new List<string>()
                {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                };

            double classAverage = LinqProblems.RunProblem5(classgrades);
            Console.WriteLine(classAverage);
            Console.ReadLine();



            //    //--------------------
            //    //Bonus Problem 1
            //    string letters = "terrill";
            //    LinqProblems.RunBonusProblem1(letters);
        }
    }
}
