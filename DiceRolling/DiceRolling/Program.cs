using System;
using System.Threading;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            
            do
            {
                LetsGetRollin();
            
            } while (Continue());
            Console.Clear();
            Console.WriteLine("\n\nThank you for playing!");
            Thread.Sleep(2000);
        }

        private static void LetsGetRollin()
        {
            int rand1;
            int rand2;

            Console.Clear();

            int sides = GetInt("How many sides should each dice have? >>");
            DiceRoller(ref sides, out rand1, out rand2);

            int firstDice = rand1;
            int secondDice = rand2;

            Console.WriteLine($"You rolled a {firstDice} and a {secondDice}");
            DiceOut(firstDice, secondDice, ref sides);
        }

        static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        static void DiceRoller(ref int sides, out int rand1, out int rand2)
        {
            Random dice = new Random();
            rand2 = dice.Next(1, sides + 1);
            rand1 = dice.Next(1, sides + 1);
        }
        static void DiceOut(int a, int b, ref int sides)
        {
            if (sides == 6)
            {
                int sum = (a + b);
                if (a == 1 && b == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                else if (a == 1 && b == 2)
                {
                    Console.WriteLine("Ace Deuce!");
                }
                else if (a == 6 && b == 6)
                {
                    Console.WriteLine("Boxcars");
                }
                else if (sum == 7 || sum == 11)
                {
                    Console.WriteLine("Win");
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    Console.WriteLine("Craps!");
                }

            }
        }
        static bool Continue()
        {
            char c;

            do
            {
                Console.WriteLine("Would you like to continue? y/n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
            } while (c != 'y' && c != 'Y');

            return true;

        }
    }
}
