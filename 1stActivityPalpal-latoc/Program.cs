using infosoft_crash_course;
using System;
using System.Security.Cryptography.X509Certificates;

namespace _1stActivityPalpal_latoc
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            do
            {
                string name = "";
                int numberOfSubjects;
                string[] subjects;
                double[] grades;
                bool option;


                while (string.IsNullOrEmpty(name))
                {
                    Console.Write("Please enter your Name: ");
                    name = Console.ReadLine();
                }

                while (true)
                {
                    Console.Write("Enter the number of subjects: ");
                    if (int.TryParse(Console.ReadLine(), out numberOfSubjects) && numberOfSubjects > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }

                subjects = new string[numberOfSubjects];
                grades = new double[numberOfSubjects];

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
                        if (double.TryParse(Console.ReadLine(), out grades[i]) && grades[i] >= 0 && grades[i] <= 100)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                    }

                }

                double totalSum = grades.Sum();



                //call the base class with the child class
                Abstract_Class CalculateGrade = new CalculateGrade(name, numberOfSubjects, subjects, grades, totalSum);

                // used the polymorphed function
                CalculateGrade.calculateGrade();

                Console.WriteLine("\nDo you want to calculate another grade? (Y/N): ");
                choice = Console.ReadLine();

            } while (choice.Equals("Y", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Thank you for using the Grading System!");

        }









    }
}