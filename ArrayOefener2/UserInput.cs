using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefener2
{
    internal class UserInput
    {
        public int[] UserMultiInput() 
        {
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Geef 5 cijfers in");
                Console.Write("[    ]");
                Console.SetCursorPosition(1, 1);
                result[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return result;            
        }
    }
}
