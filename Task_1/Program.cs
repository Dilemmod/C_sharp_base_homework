using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Student
    {
        public int tails;
        public bool drunk = false;
        public int iq;
        public string name;
        public string department;
        public void nameDepartment()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your department: ");
            department = Console.ReadLine();
        }
        public bool Expelled()
        {
            if (iq < 70 & drunk | drunk & tails > 3 | iq < 70 & tails > 3) 
            {
                Console.WriteLine("Student EXPELLED");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void getInfo()
        {
                Console.WriteLine("How much the student drunk: " + (drunk ? "Dead drunk" : "Sober"));
                Console.WriteLine("IQ test scores: " + iq);
                Console.WriteLine("How much student debt: " + tails); ;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Random r = new Random();
            stud.nameDepartment();
            stud.tails = r.Next(0, 6);
            stud.iq = r.Next(0, 140);
            int dr = r.Next(0, 2);
            stud.drunk = (dr == 0 ? false : true);
            stud.getInfo();
            if (stud.Expelled()) {}
            else
            {
                dr = r.Next(0, 2);
                stud.drunk = (dr == 0 ? false : true);
                stud.iq += (stud.drunk ? 0 : 10);
                stud.getInfo();
            }

            Console.ReadKey();
        }
    }
}
