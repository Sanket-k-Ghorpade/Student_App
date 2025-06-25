using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }

        private double percentage;

        // Default Constructor
        public Student() { }

        //Parameterised Constructor
        public Student(int rollNo, string name, double cgpa)
        {
            if(rollNo < 0) { throw new ArgumentOutOfRangeException(nameof(rollNo), "Roll no should be positive"); }
            if(cgpa < 1 || cgpa > 10) { throw new ArgumentOutOfRangeException(nameof(cgpa), "CGPA should be in the range 1-10"); }
            RollNo = rollNo;
            CGPA = cgpa;
            if (name.Length < 5) Name = "";
            else Name = name;
        }

        public double CalculatePercentage()
        {
            return percentage = Math.Round(7.1 * CGPA + 11,2);
        }
    }
}
