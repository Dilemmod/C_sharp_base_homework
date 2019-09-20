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
            Random rand = new Random();
            byte r = (byte)(rand.Next(0, 101)), n = 0, user =0;
            for (byte i=0; i<5; i++)
            {
                n++;
                Console.Write("Try #" + n + " Enter your number ");
                user = Convert.ToByte(Console.ReadLine());
                Console.WriteLine(user==r? "Congratulations! This is my number!":(user < r? "Wrong! My number is bigger!":"Wrong! My number is less!"));
                if(user==r)
                {
                    break;
                }
            }
            Console.WriteLine(user != r ? "Your lose! My number is "+r:"");
            Console.ReadKey();
        }
    }
}
