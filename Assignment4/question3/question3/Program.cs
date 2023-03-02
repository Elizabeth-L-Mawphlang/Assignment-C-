using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Doctor doctor = new Doctor("John Barley", "Australia", 98766, 1000, "Cardiology");
           
        }



        public class Person
        {
            protected string Name;
            protected string Address;

            public Person(string name, string address)
            {
                this.Name = name;
                this.Address = address;
            }
        }

        public class Doctor : Person
        {
            private int RegnNo;
            private int FeesCharged;
            private string Specialization;

            public Doctor(string name, string address, int regnNo, int feesCharged, string specialization) : base(name, address)
            {
                this.RegnNo = regnNo;
                this.FeesCharged = feesCharged;
                this.Specialization = specialization;
            }

        }
    }
}
