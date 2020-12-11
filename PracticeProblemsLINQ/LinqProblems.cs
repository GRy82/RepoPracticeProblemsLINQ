using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25

        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> wordsWithTh = words.Where(w => w.Contains("th")).ToList();
            //return
            return wordsWithTh;
        }


        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            var unduplicatedStrings = names.Distinct().ToList();
            //return
            return unduplicatedStrings;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer customerMike = customers.Single(c => c.FirstName.Equals("Mike"));

            //return
            return customerMike;
        }

        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            Customer customer3 = customers.Single(c => c.Id == 3);

            customer3.FirstName = "William";
            customer3.LastName = "Hung";
            //return
            return customer3;

        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            double allGrades = 0;
            //code
            foreach(string gradeSet in classGrades)
            {
                string[] splitGrades = gradeSet.Split(',');// 
                int[] splitGradesInt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    splitGradesInt[i] = Convert.ToInt32(splitGrades[i]);
                }
                List<int> splitGradesList = splitGradesInt.OrderByDescending(s => s).ToList();
                splitGradesList.Remove(splitGradesList.Min());
                allGrades += splitGradesList.Average();
            }
            allGrades /= classGrades.Count;
            //return
            return allGrades;
        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            //code
            List<char> terrillName = word.OrderBy(w => w).ToList();
            List<char> distinctLetters = word.Distinct().OrderBy(s => s).ToList();
            string returnString = null;
            foreach(char character in distinctLetters)
            {
                int letterFrequency = terrillName.Where(c => c == character).Count();
                returnString += character.ToString().ToUpper() + letterFrequency;
            }
            //return
            return returnString;
        }
        #endregion


    }
}
