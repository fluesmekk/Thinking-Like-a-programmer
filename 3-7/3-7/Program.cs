using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new[] {1, 2, 1, 4, 5, 1, 7};
            int[] numberOfCertainInteger = new int[10];
            for (var i = 0; i < integerArray.Length; i++)
            {
                numberOfCertainInteger[integerArray[i]-1]++;
            }
            var number = 1;
            for (var j = 0; j < numberOfCertainInteger.Length; j++)
            {
                
                Console.WriteLine("Number "+ number + " " +numberOfCertainInteger[j]);
                number++;
            }

            int maxValue = numberOfCertainInteger.Max();
            int indexOfHighestValue = numberOfCertainInteger.ToList().IndexOf(maxValue);
            Console.WriteLine();
            Console.WriteLine("The integer "+(indexOfHighestValue+1)+" has the highest value");
            //Console.Write(indexOrModeNumber);
        }
    }
}
