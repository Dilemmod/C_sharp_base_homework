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
            if (m >= 80) Console.WriteLine($"You can buy 1 Leffe, the rest {m - 80}");
            else if (m >= 70) Console.WriteLine($"You can buy 1 Hoegarsen, the rest {m - 70}");
            else if (m >= 60) Console.WriteLine($"You can buy 1 Stella, the rest {m - 60}");
            else if (m >= 7) Console.WriteLine($"You can buy 1 Obolon, the rest {m - 7}");
            else Console.WriteLine($"You can't buy any beer"); 
            Console.ReadKey();
        }
    }
}
