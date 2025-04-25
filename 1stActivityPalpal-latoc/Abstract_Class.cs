using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stActivityPalpal_latoc
{
    // Abstraction
   public abstract class Abstract_Class
    {
        //encapsulation
        public string name { get; set; }
        public int numberOfSubjects { get; set; } 
        public string[] subjects { get; set; }
        public double[] grades { get; set; }

        public Abstract_Class(string name, int numberOfSubjects, string[] subjects, double[] grades)
        {
            this.name = name;
            this.numberOfSubjects = numberOfSubjects;
            this.subjects = subjects;
            this.grades = grades;
        }

        // Abstraction of function can be morph into sometime from the other class
        public abstract void calculateGrade();
       




    }
}
