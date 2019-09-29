using System;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month = new int[12];
            for (int i = 0; i < month.Length; i++)
            {
                Console.Write((month[i] = (i == 1 ? 28 : (i > 6 ? (i % 2 == 0 ? 30 : 31) : (i % 2 == 0 ? 31 : 30)))) + " ");
            }
            Console.ReadKey();
        }
    }
}
