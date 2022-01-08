using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadder
{
    internal class Program
    {
        static int[] board = new int[100];
        static int p1, p2;

        static int dice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);

        }

        static void snakes(ref int n)
        {
            if (n == 98)
            {
                n = 79;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 95)
            {
                n = 75;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 93)
            {
                n = 73;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 87)
            {
                n = 45;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 62)
            {
                n = 19;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 54)
            {
                n = 34;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
            else if (n == 17)
            {
                n = 7;
                Console.WriteLine("Oops! You've been bit by a snake. New positon = " + n);
            }
        }

        static void ladders(ref int n)
        {
            if (n == 80)
            {
                n = 99;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 72)
            {
                n = 91;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 28)
            {
                n = 84;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 51)
            {
                n = 67;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 21)
            {
                n = 42;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 4)
            {
                n = 14;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
            else if (n == 9)
            {
                n = 31;
                Console.WriteLine("Congratulations! You found a ladder and climbed it. New positon = " + n);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladder!");
            int no = 0;
            p1 = 0;
            p2 = 0;
            bool won = false;
            while (won != true)
            {
                Console.WriteLine("Select an option: \n" + "1. Player 1 moves.\n" + "2. Player 2 moves.\n");
                no = Convert.ToInt32(Console.ReadLine());
                switch (no)
                {
                    case 1:
                        int x = dice();
                        int y = dice();
                        Console.WriteLine("Dice 1: " + x + "\nDice 2: " + y);
                        int pos = x + y;
                        if (p1 > 93 && ((pos + p1) != 100))
                        {
                            Console.WriteLine("Unable to reach 100th block, please try again later.");
                            break;
                        }
                        p1 += pos;
                        Console.WriteLine("Position of Player 1 = " + p1);
                        snakes(ref p1); 
                        ladders(ref p1);
                        if (p1 == 100)
                            won = true;
                        Console.WriteLine();
                        break;

                    case 2:
                        int x1 = dice();
                        int y1 = dice();
                        Console.WriteLine("Dice 1: " + x1 + "\nDice 2: " + y1);
                        int pos1 = x1 + y1;
                        if (p2 > 93 && ((pos1 + p2) != 100))
                        {
                            Console.WriteLine("Unable to reach 100th block, please try again later.");
                            break;
                        }
                        p2 += pos1;
                        Console.WriteLine("Position of Player 1 = " + p2);
                        snakes(ref p2);
                        ladders(ref p2);
                        if (p2 == 100)
                            won = true;
                        Console.WriteLine();
                        break;

                    default: Console.WriteLine("Invalid Input");
                        break;
                }
            }
            if(p1 == 100)
                Console.WriteLine("Congratulation Player 1! You won.\n" + "Thank you for playing!");
            else if(p1 == 100)
                Console.WriteLine("Congratulation Player 2! You won.\n" + "Thank you for playing!");
            Console.ReadLine();
        }
    }
}
