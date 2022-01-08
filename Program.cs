using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadder
{
    internal class Program
    {
        static int[,] board = new int[10, 10];
        int p1, p2;

        static void set()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                        board[i , j] = 100 - j;
                }               
            } 
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

        static void ladder(ref int n)
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
        }
    }
}
