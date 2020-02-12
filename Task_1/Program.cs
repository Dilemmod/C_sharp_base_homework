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
            new Game();
        }
        public class Game
        {
            public Game()
            {
                MetodGame();
            }
            void MetodGame()
            {
                int hp = 100, ai = 0, aj = 0;
                ConsoleKeyInfo wasd;
                Random r = new Random();
                char[][] game = new char[10][];
                for (byte i = 0; i < game.Length; i++)
                {
                    game[i] = new char[10];
                }
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
                    hp = (hp > 100 ? 100 : hp);
                    Console.WriteLine("Your health = " + (hp < 10 ? "00" : (hp < 100 ? "0" : "")) + hp);
                    wasd = Console.ReadKey();
                    Console.SetCursorPosition(0, 0);
                    char temp = game[ai][aj];
                    game[ai][aj] = '-';
                    int f = (r.Next(0, 2) == 0 ? 40 : 20), da = aj, sw = ai;
                    switch (wasd.Key.ToString())
                    {
                        case "D":
                            da = (aj == game.Length - 1 ? 0 : aj + 1);
                            break;
                        case "A":
                            da = (aj == 0 ? game.Length - 1 : aj - 1);
                            break;
                        case "S":
                            sw = (ai == game.Length - 1 ? 0 : ai + 1);
                            break;
                        case "W":
                            sw = (ai == 0 ? game.Length - 1 : ai - 1);
                            break;
                        default:
                            continue;
                    }
                    hp = (game[sw][da] == '*' ? hp - f : (game[sw][da] == '#' ? hp + f : hp));
                    game[sw][da] = temp;
                    aj = da; ai = sw; hp -= 5;
                    if (ai == game.Length - 1 && aj == game.Length - 1)
                    {
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine(ai == game.Length - 1 && aj == game.Length - 1 ? "You win!!!" : "You LOSE");
                Console.WriteLine("Enter Key");
                Console.ReadKey();
                Console.ReadKey();
                Console.Clear();
                MetodGame();

            }

        }
    }
}
