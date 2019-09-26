using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] game = { '@', '_', '_', '_', '_', '_' };
            Random r = new Random();
            byte i = 0;
            int hp = 100;
            int b = r.Next(1, game.Length), m = r.Next(1, game.Length);
            b = (m == b ? r.Next(1,game.Length):b);
            game[m] = '#';
            game[b] = '*';
            while (i<game.Length-1)
            {
                int five = r.Next(0, 2);
                //Вивід масиву
                
                for (int j = 0; j < game.Length; j++)
                {
                    Console.Write(game[j] + " ");
                }
                Console.WriteLine();
                //Перевірка на виграш
                if (i == game.Length - 1||hp<0)
                {
                    break;
                }
                Console.WriteLine("Your health = " + (hp > 100 ? hp=100 : hp));
                //Перевірка символу
                string da = Console.ReadLine();
                //Обновление
                if (da == "d")
                {
                    char temp = game[i];
                    game[i] = game[i + 1];
                    game[i + 1] = temp;
                    //Вибух
                    if (i+1 == b)
                    {
                        game[--b] = '_';b = game.Length-1;
                        hp -= (five == 0 ? 40 : 20);
                    }
                    //Аптечка
                    else if (i+1 == m)
                    {
                        game[--m] = '_';m = game.Length - 1;
                        hp += (five == 0 ? 40 : 20);
                    }
                    i++;
                }
                else if (da == "a")
                {
                    //@ вийшов за межі масиву
                    if (i == 0)
                    {
                        break;
                    }
                    char temp = game[i];
                    game[i] = game[i - 1];
                    game[i - 1] = temp;
                    //Вибух
                    if (i-1 == b)
                    {
                        game[++b] = '_';b = game.Length - 1;
                        hp -= (five == 0 ? 40 : 20);
                    }
                    //Аптечка
                    else if (i-1 == m)
                    {
                        game[++m] = '_';m = game.Length - 1;
                        hp += (five == 0 ? 40 : 20);
                    }
                    i--;
                }
                hp -= 5;
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine(i==game.Length-1?"You WIN!!!":"You LOSE");


            Console.ReadKey();
        }
    }
}
