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
            byte[] big = { 3,3,3,3,3,3,3};
            byte[] litle = { 6,6,6};
            int b = (big.Length - litle.Length)/2;
            Array.Copy(litle,0, big, b,litle.Length);
            for (int i = 0; i < big.Length; i++)
            {
                Console.Write(big[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
