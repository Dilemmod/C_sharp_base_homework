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
            char[][] game = new char[10][];
            //Іниціалізація
            for (byte i = 0; i < game.Length; i++)
            {
                game[i] = new char[10];
            }

            byte ai = 0, aj = 0;
            int hp = 100;
            ConsoleKeyInfo wasd;
            for (byte i = 0; i < game.Length; i++)
            {
                for (byte j = 0; j < game[i].Length; j++)
                {
                    game[i][j] = '-';
                    game[ai][aj] = '@';
                    game[game.Length - 1][game.Length - 1] = 'x';
                }
            }
            while (hp > 0)
            {
                for (byte i = 0; i < game.Length; i++)
                {
                    for (byte j = 0; j < game[i].Length; j++)
                    {
                        Console.Write(game[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Your health = " + (hp < 10 ? "00" : (hp < 100 ? "0" : ""))+hp);
                wasd = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                char temp = game[ai][aj];
                switch (wasd.Key.ToString())
                {
                    case "D":
                        if (aj == game.Length-1)
                        {
                            game[ai][aj] = game[ai][0];
                            game[ai][0] = temp;
                            aj=0;
                        }
                        else
                        {
                            game[ai][aj] = game[ai][aj + 1];
                            game[ai][aj+1] = temp;
                            aj++;
                        }
                        break;
                    case "A":
                        if(aj==0)
                        {
                            game[ai][aj] = game[ai][game.Length-1] ;
                            game[ai][game.Length - 1] = temp;
                            aj=Convert.ToByte(game.Length - 1);
                        }else
                        {
                            game[ai][aj] = game[ai][aj - 1];
                            game[ai][aj-1] = temp;
                            aj--;
                        }
                        break;
                    case "S":
                        if (ai == game.Length-1)
                        {
                            game[ai][aj] = game[0][aj];
                            game[0][aj] = temp;
                            ai = 0;
                        }
                        else
                        {
                            game[ai][aj] = game[ai + 1][aj];
                            game[ai + 1][aj] = temp;
                            ai++;
                        }
                        break;
                    case "W":
                        if (ai == 0)
                        {
                            game[ai][aj] = game[game.Length - 1][aj];
                            game[game.Length - 1][aj] = temp;
                            ai = Convert.ToByte(game.Length - 1);
                        }
                        else
                        {
                            game[ai][aj] = game[ai - 1][aj];
                            game[ai - 1][aj] = temp;
                            ai--;
                        }
                        break;
                    default:
                        continue;
                }
                if(ai == game.Length - 1 && aj == game.Length - 1)
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
