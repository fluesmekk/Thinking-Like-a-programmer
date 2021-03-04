using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinking_like_a_programmer__Katpitell_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 0, 2, 1, 3 };
            CheckArray(array1);
        }
        
        static bool CheckArray(int[] array1)
        {
            if (array1.Length > 0)
            {
                Array.Sort(array1);
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
