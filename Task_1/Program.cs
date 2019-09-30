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
            int hp = 100, ai = 0, aj = 0;
            ConsoleKeyInfo wasd;
            Random r = new Random();
            char[][] game = new char[10][];
            //Іниціалізація
            for (byte i = 0; i < game.Length; i++)
            {
                game[i] = new char[10];
            }
            //Присвоєння
            for (int i = 0; i < game.Length; i++)
            {
                int b = r.Next(0, game.Length - 1), m = r.Next(0, game.Length - 1);
                for (int j = 0; j < game[i].Length; j++)
                {
                    game[i][j] = '-';
                    game[ai][aj] = '@';
                    game[game.Length - 1][game.Length - 1] = 'x';
                    while ((b == m) || (i == 0 && (b == 0 || m == 0))) 
                    {
                        m = r.Next(0, game.Length);
                        b = r.Next(0, game.Length);
                    }
                    game[i][b] = '*';
                    game[i][m] = '#';
                }
            }
            //Цикл гри
            while (hp > 0)
            {
                for (int i = 0; i < game.Length; i++)
                {
                    for (int j = 0; j < game[i].Length; j++)
                    {
                        Console.Write(game[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                hp = (hp > 100 ? 100:hp);
                Console.WriteLine("Your health = " + (hp < 10 ? "00" : (hp < 100 ? "0" :""))+hp);
                wasd = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                char temp = game[ai][aj];
                int f = (r.Next(0, 2) == 0 ? 40 : 20);
                switch (wasd.Key.ToString())
                {
                    case "D":
                        int d = (aj == game.Length - 1 ? 0 : aj + 1);
                        hp = (game[ai][d] == '*' ? hp - f : (game[ai][d] == '#' ? hp + f : hp));
                        game[ai][aj] = '-';
                        game[ai][d] = temp;
                        aj = d;
                        break;
                    case "A":
                        int a = (aj == 0 ? game.Length - 1 : aj - 1);
                        hp = (game[ai][a] == '*' ? hp - f : (game[ai][a] == '#' ? hp + f : hp));
                        game[ai][aj] = '-';
                        game[ai][a] = temp;
                        aj = a;
                        break;
                    case "S":
                        int s = (ai == game.Length - 1 ? 0 : ai + 1);
                        hp = (game[s][aj] == '*' ? hp - f : (game[s][aj] == '#' ? hp + f : hp));
                        game[ai][aj] = '-';
                        game[s][aj] = temp;
                        ai = s;
                        break;
                    case "W":
                        int w = (ai == 0 ? game.Length - 1 : ai - 1);
                        hp = (game[w][aj] == '*' ? hp - f : (game[w][aj] == '#' ? hp + f : hp));
                        game[ai][aj] = '-';
                        game[w][aj] = temp;
                        ai = w;
                        break;
                    default:
                        continue;
                }
                if (ai == game.Length - 1 && aj == game.Length - 1)
                {
                    break;
                }
                hp -= 5;
            }
            Console.Clear();
            Console.WriteLine(ai == game.Length - 1 && aj == game.Length - 1 ? "You win!!!" : "You LOSE");
            Console.ReadKey();
        }
    }
}
