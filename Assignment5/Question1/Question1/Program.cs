using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Undergraduate undergraduate = new Undergraduate();
            undergraduate.Name = "Konsam Dev Kanta";
            undergraduate.StudentId = 1224;
            undergraduate.Grade = 30;
            Console.WriteLine("Undergraduate is Passed: " + undergraduate.IsPassed(undergraduate.Grade));

            Graduate graduate = new Graduate();
            graduate.Name = "Jonah Suchiang";
            graduate.StudentId = 45677;
            graduate.Grade = 10;
            Console.WriteLine("Graduate is Passed: " + graduate.IsPassed(graduate.Grade));
            Console.Read();

        }
        public abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        public class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 80.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
