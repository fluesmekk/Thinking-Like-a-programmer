using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCross
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var number in array) DrawSequence(number);
        }

        static void DrawSequence(int number)
        {
            DrawEmptyLine(number);
            DrawSquare(number);
            DrawMiddlePart(number);
            DrawSquare(number);
            DrawEmptyLine(number);
            
            Console.WriteLine();
        }

        static void DrawMiddlePart(int number)
        {
            var middle = 12 - number * 4;
            for (var i = 0; i < middle; i++)
            {
                Console.Write(" ");
            }

        }

        static void DrawSquare(int number)
        {
            for (var i = 0; i < number + 1; i++)
            {
                Console.Write("#");
            }
        }

        static void DrawEmptyLine(int number)
        {
            for (var i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
