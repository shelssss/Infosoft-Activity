using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class GradingSystem
    {
        //1st-Infosoft-Activity


        public GradingSystem()
        {
            string name = "";
            int numberOfSubjects;
            string[] subjects;
            int[] grades;

            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Please enter your Name: ");
                name = Console.ReadLine();
            }

            while (true)
            {
                Console.Write("Enter the number of subjects: ");
                if (int.TryParse(Console.ReadLine(), out numberOfSubjects) && numberOfSubjects > 0) //error handling
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            subjects = new string[numberOfSubjects];
            grades = new int[numberOfSubjects];

            for (int i = 0; i < numberOfSubjects; i++)
            {
                Console.Write($"Enter Subject Number {i + 1}: ");
                subjects[i] = Console.ReadLine();


            }
            Console.WriteLine();
            for (int i = 0; i < numberOfSubjects; i++)
            {
                while (true)
                {
                    Console.Write($"Enter grade for Subject {subjects[i]}: ");
                    if (int.TryParse(Console.ReadLine(), out grades[i]) && grades[i] >= 0 && grades[i] <= 100) //error handling 
                    {
                        break;
                    }
                    Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                }

            }

            // sum array using LINQ feature in C#
            double totalSum = grades.Sum();

            // provided 2 formula
            // total percentage to use in the finalAvg 
            double totalPercentage = numberOfSubjects / 100.0;
            double finalAvg = totalSum / (totalPercentage * 100);

            // another formula for final Average
            // type cast the total sum as double for ensuring correct output
            double finalAverage = (double)totalSum / (numberOfSubjects * 100) * 100;
            
            // original average formula
            double finalG = totalSum / numberOfSubjects;


            if (finalAverage < 75)
            {
                Console.WriteLine($"Your Final Average is: {finalAverage:F2}");
                Console.WriteLine("Which is considered as Failed");
            }
            else if (finalAverage >= 75 && finalAverage <= 100)
            {
                Console.WriteLine($"Your Final Average is: {finalAverage:F2}");
                Console.WriteLine("Which is considered as Passed");
            }
            else
            {
                Console.WriteLine("Your Grade is Invalid");
            }

        }

    }
}