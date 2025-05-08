using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class gradesstudent
    {
        double[] grade=new double[5] { 95, 90, 50, 66,70 };
        public double this[int index]
        {
            get { return grade[index]; }
            set { grade[index] = value; }
        }
        public double[] Grade
        {
            get {  return grade; }
            set { grade = value; }
        }
        public override string ToString()
        {
            return "Grades: " + string.Join(", ", grade);
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gradesstudent gradesstudent = new gradesstudent();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(gradesstudent[i]);
            }
            
            gradesstudent[2] = 88;
            Console.WriteLine(gradesstudent);
        }
    }
}
