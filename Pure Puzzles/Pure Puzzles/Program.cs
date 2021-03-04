using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int count = 8;

            int number1 = 4;
            //Upper diamond
            for (var i = 4; i > 0; i--)
            {
                for (var x = 0; x < number1-1; x++)
                {
                    Console.Write(" ");
                   
                }
                number1--;
                for (var j = 0; j < count - number1 * 2; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            //Lower diamond
            for (var i = 4; i > 0; i--)
            {
                if (i == 4) number = 0;
                else number++;
                for (var x = 0; x < number; x++)
                {
                    Console.Write(" ");
                }
                for (var j = 0; j < i * 2; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }


            // Cross

            Array();




        }

        private static void Array()
        {
            var iValues = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var value in iValues) DrawCross(value);
        }

        private static void DrawCross(int value)
        {
            DrawSpaces(value);
        }

        private static void DrawSpaces(int value)
        {
            for (var i = 0; i < value; i++)
            {
                Console.Write(" ");
            }
            for (var i = 0; i < value; i++)
            {
                Console.Write("#");
            }

            var valueEmpty = 12 - value;
            for (var x = 0; x < valueEmpty; x++)
            {
                Console.Write(" ");
            }
        }
    }
}
