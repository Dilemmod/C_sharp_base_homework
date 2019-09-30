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
            Console.WriteLine("Enter your last name, first name and patronymic through by space");
            string name = Console.ReadLine();
            string last = name.Substring(1, name.IndexOf(" "));
            string first = name.Substring(name.IndexOf(" ") + 1, 1);
            string middle = name.Substring(name.LastIndexOf(" ") + 1, 1);
            Console.WriteLine((name.Substring(0, 1)).ToUpper() + last + first.ToUpper() + "." + middle.ToUpper() + ".");
            Console.ReadKey();
        }
    }
}
