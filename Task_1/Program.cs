using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Student
    {
        private int tails;
        private bool drunk;
        private int iq;
        private string name;
        private string department;
        
        public void setNameDepartment()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your department: ");
            department = Console.ReadLine();
        }
        public void Expelled(bool drunk)
        {
            if (iq < 70 & drunk | drunk & tails > 3 | iq < 70 & tails > 3) 
            {
                Console.WriteLine("Student EXPELLED");
            }
            else
            {
                this.drunk = drunk;
                iq += (drunk == false ? 10 : 0);
                getInfo();
            }
        }
        // public bool setRandDrunk(bool i)
        public void setRand(int tails,int iq,bool drunk)
        {
            this.tails = tails;
            this.iq = iq;
            this.drunk = drunk;
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
            Random rand = new Random();
            int dr = rand.Next(0, 2);
            stud.setNameDepartment();
            stud.setRand(rand.Next(0, 6), rand.Next(0, 180), (dr == 0 ? false : true));
            stud.getInfo();

            dr = rand.Next(0, 2);
            stud.Expelled((dr == 0 ? false : true));

            Console.ReadKey();
        }
    }
}
