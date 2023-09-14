using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the diamond (half-height):");
            int height;
            if (int.TryParse(Console.ReadLine(), out height))
            {
                DrawDiamond(height);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        static void DrawDiamond(int height)
        {
            // Upper part of the diamond (pyramid)
            for (int i = 1; i <= height; i++)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower part of the diamond (inverted pyramid)
            for (int i = height - 1; i >= 1; i--)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
