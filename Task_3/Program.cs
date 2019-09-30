using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your last name, first name and patronymic through by space = ");
            string name = Console.ReadLine();
            string last = (name.Substring(0, 1).ToUpper()) + name.Substring(1, name.IndexOf(" ")-1);
            string first = (name.Substring(name.IndexOf(" ") + 1, 1).ToUpper()) + name.Substring(name.IndexOf(" ") + 2, name.LastIndexOf(" ") - name.IndexOf(" ") - 2);
            string middle = (name.Substring(name.LastIndexOf(" ") + 1, 1).ToUpper()) + name.Substring(name.LastIndexOf(" ") + 2, (name.Length - name.LastIndexOf(" ") - 2));
            // Console.WriteLine(last+" "+first+" "+middle);
            //Console.WriteLine(name.IndexOf("tyr"));
            string[][][] mas = new string[3][][];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new string[3][]
                {
                    new string[1] {last},
                    new string[1] {first},
                    new string[1] {middle}
                };
            }
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    for (int l = 0; l < 1; l++) 
                    {
                        Console.Write(mas[i][j][l] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Enter your search requery = ");
            //string search = Console.ReadLine();
            if (name.IndexOf(Console.ReadLine()) != -1) 
            {
                Console.WriteLine(last + " " + first + " " + middle);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadKey();
        }
    }
}
