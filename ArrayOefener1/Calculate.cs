using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefener1
{
    internal class Calculate
    {
        public double[] CheckSumAvgLargest(int[] input)
        {

            double[] result = new double[3];
            result[0] = input.Average();
            result[1] = input.Sum();
            result[2] = input.Length;
            return result;
        }
    }
}
