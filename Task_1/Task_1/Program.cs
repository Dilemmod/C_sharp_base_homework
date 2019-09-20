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
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //Кількість цифр
            int n = num;
            byte b = 0, s = 0, t = 0, d;
            do
            {
                b++;
                d = (byte)(n % 10);
                if (n % 2 == 0)
                {
                    s += d;
                }
                if (d % 3 == 0)
                {
                    t++;
                }
                n /= 10;
            } while (n > 0);
            Console.WriteLine("a) Amount of digits: " + b);
            Console.WriteLine("b) Sum of even digits: " + s);
            Console.WriteLine("c) Amount digits of multiples of 3: " + t);
            Console.ReadKey();
        }
    }
}
