using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefener1
{
    internal class UserInput
    {
        public int[] InputMain(int input = 3 ) 
        {
            int[] output = new int[input];

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"Geef {input != 1} cijfer(s) in");
                Console.Write("[");
                output[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return output;
        }
        public int InputSecond() 
        {
            int[] interMed = InputMain(1);
            int output = interMed[0];
            return output;
        }
    }
}
