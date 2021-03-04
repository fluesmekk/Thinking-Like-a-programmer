using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // oppgave 3-4 pre så post, 3-5 post så pre, 
            char[] arrayPost = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z', ' ',
            };
            char[] arrayPre = new char[]
            {
                '2', '1', '3', '6', '7', '4', '5', 'X', 'Z', 'C', 'Q', 'W', 'R', 'P', 'J', 'Y', 'T', '9', '8', 'L', 'S',
                'A', 'H', 'F', 'U', 'M', ' ',
            };
            var text = Console.ReadLine();
            text = text.ToUpper();
            for (var i = 0; i < text.Length; i++)
            {
                for (var j = 0; j < arrayPre.Length; j++)
                {
                    if (text[i] == arrayPre[j])
                    {
                        Console.Write(arrayPost[j]);
                    }
                }
            }

        }
    }
}
