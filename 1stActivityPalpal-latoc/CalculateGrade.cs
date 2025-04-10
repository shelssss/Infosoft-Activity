using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stActivityPalpal_latoc
{
    class CalculateGrade : Abstract_Class //inheritance
    {
        double sumGrades { get; set; }

        public CalculateGrade(string name, int numberOfSubjects, string[] subjects, double[] grades, double sumGrades) : base(name, numberOfSubjects, subjects, grades)
        {

            this.sumGrades = sumGrades;
        }

        public override void calculateGrade() //override the function polymorphism
        {
            double finalAverage = (double)sumGrades / numberOfSubjects;


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
