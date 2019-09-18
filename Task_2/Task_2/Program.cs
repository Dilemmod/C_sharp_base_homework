using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how  much money do you have");
            int m = Convert.ToInt32(Console.ReadLine());
            string b = "";
            if (m >= 80)
            {
                b = "leffe";
                m -= 80;
            }
            else if (m >= 70)
            {
                b = "Hoegarsen";
                m -= 70;
            }
            else if (m >= 60)
            {
                b = "Stella";
                m -= 60;
            }
            else if (m >= 7)
            {
                b = "Obolon";
                m -= 7;
            }
            else Console.WriteLine($"You can't buy any beer");

            Console.WriteLine($"You can buy 1 {b}, the rest {m}");
            Console.ReadKey();
        }
    }
}
