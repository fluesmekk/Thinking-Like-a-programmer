using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Word_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var textArray = text.Split(' ');
            var longestWord = textArray.OrderByDescending( s => s.Length).First();
            var count = textArray.Length;

            var vowels = new[] { 'a', 'e', 'i', 'o', 'u'};
            var vowelCount = 0;

            for (var i = 0; i < textArray.Length; i++)
            {
                for (var j = 0; j < textArray[i].Length; j++)
                {
                    if (vowels.Contains(textArray[i][j]))
                    {
                        vowelCount++;
                    }
                }
            }
            
            Console.Write("Du skrev " + count +  " Ord");
            Console.WriteLine();
            Console.Write("Det lengste order du skrev var ordet: " + longestWord);
            Console.WriteLine();
            Console.Write("Antall vokaler du har brukt i setningen din er " + vowelCount);
        }
    }
}
