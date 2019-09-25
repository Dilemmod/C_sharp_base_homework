﻿using System;
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
            while (i<game.Length-1)
            {
                int b = r.Next(0, game.Length), m = r.Next(0, game.Length);
                int five = r.Next(0, 2);
                //Вивід масиву
                for (int j = 0; j < game.Length; j++)
                {
                    _ = (i != b ? (game[b] = '*') : (b = r.Next(0, game.Length)));
                    _ = (i != m ? (game[m] = '#') : (m = r.Next(0, game.Length)));
                    Console.Write(game[j] + " ");
                }
                Console.WriteLine();
                game[b] = '_';
                game[m] = '_';
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
                    if (i + 1 == b)
                    {
                        hp -= (five == 0 ? 40 : 20);
                    }
                    //Аптечка
                    else if (i + 1 == m)
                    {
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
                    if (i - 1 == b)
                    {
                        hp -= (five == 0 ? 40 : 20);
                    }
                    //Аптечка
                    else if (i - 1 == m)
                    {
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