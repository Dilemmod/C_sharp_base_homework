using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your check amount");
            int m = Convert.ToInt32(Console.ReadLine());
            byte z;
            if (m >= 500) z = 5;
            else if (m >= 400) z = 3;
            else if (m >= 300) z = 2;
            else z = 0;
            Console.WriteLine($"Your discound is {z}%, total to pay {m-(m*z/100)}");
            Console.ReadKey();
        }
    }
}
