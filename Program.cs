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
        static int p1, p2;

        static void set()
        {
            int k = 1;
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                        board[i , j] = k++;
                }               
            } 
        }

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

        static bool won()
        {
            if (p1 == 100 || p2 == 100) ;
            return true;
        }

        static void Main(string[] args)
        {
            set();
            Console.WriteLine("Welcome to Snakes and Ladder!");
            int no = 0;
            p1 = board[0, 0];
            p2 = board[0, 0];
            while(won() != true)
            {
                Console.WriteLine("Select an option: \n" + "1. Player 1 moves.\n" + "2. Player 2 moves.\n");
                no = Convert.ToInt32(Console.ReadLine());
                switch(no)
                    case 1: int x = dice();
                            int y = dice();
                            int pos = x + y;
                            p1 = board[,];
                            snakes(ref p1);
                            ladders(ref p1);
                case 2:int x = dice();
                               int y = dice();
                               int pos = x + y;
                               p2 = board[,];
                               snakes(ref p2);
                               ladders(ref p2);
                }
        }
    }
}
