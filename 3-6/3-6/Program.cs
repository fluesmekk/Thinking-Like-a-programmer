using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayAlphabet = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
                'X', 'Y', 'Z', ' '
            };
            Random rnd = new Random();
            char[] randomArray = arrayAlphabet.OrderBy(x => rnd.Next()).ToArray();
            Console.Write(randomArray);
            var text = Console.ReadLine().ToUpper();
            for (var i = 0; i < text.Length; i++)
            {
                for (var j = 0; j < arrayAlphabet.Length; j++)
                {
                    if (text[i] == arrayAlphabet[j])
                    {
                        Console.Write(randomArray[j]);
                    }
                }
            }
        }
    }
}
