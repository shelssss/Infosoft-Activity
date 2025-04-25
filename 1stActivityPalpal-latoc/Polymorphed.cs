using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stActivityPalpal_latoc
{
    public class Polymorphed : Abstract_Class
    {   
      
        public Polymorphed(string name, int numberOfSubjects, string[] subjects, double[] grades, string status) : base(name, numberOfSubjects, subjects, grades)
        {
           
        }

        public override void calculateGrade()
        {
            Console.WriteLine("Polymorphed");
        }
    }
}
