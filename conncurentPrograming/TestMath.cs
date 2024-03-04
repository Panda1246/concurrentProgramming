using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conncurentPrograming
{
    internal class TestMath
    {
        public static int mathPow(int baseNumber, int exponent)
        {

            if (exponent == 0 && baseNumber == 0)
            {
                throw new Exception("Wrong input data provided");
            }
            else if (exponent == 0)
            {
                return 1;
            }
            int finalValue = baseNumber;
            for (int i = 0; i < exponent - 1; i++)
            {
                finalValue *= baseNumber;
            }
            return finalValue;
        }
    }
}
