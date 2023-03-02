using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dayscholar d =new Dayscholar();
            d.ShowDetails();
            Console.WriteLine("\n***********************\n");
            Resident r = new Resident();
            r.ShowDetails();

            Console.Read();
        }
        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }

        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; } = 123;
            public string Name { get; set; } = "James";
            public float Fees { get; set; } = 50000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\n Name: {Name}\n Fees: {Fees}" );
            }
        }

        public class Resident : IStudent
        {
            public int StudentId { get; set; } = 321;
            public string Name { get; set; } = "Alvin";
            public float Fees { get; set; } = 100000;

            public void ShowDetails()
            {
                Console.WriteLine($"Student ID: {StudentId}\n Name: {Name}\n Fees: { Fees}" );
                Console.ReadLine();
            }
        }
    }
}
