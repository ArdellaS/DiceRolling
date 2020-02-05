using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRolling
{
    public class DiceRolling
    {
        public static void DiceOut(int a, int b, ref int sides)
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
    }
}
