using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int minim;

            if (number1 < number2)
            {
                minim = number1;
            }
            else
            {
                minim = number2;
            }
            return minim;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int minim;

            if ((number1 < number2) && (number1 < number3))
            {
                minim = number1;

            }
            else if ((number2 < number3) && (number2 < number1))
            {
                minim = number2;
            }
            else
            {
                minim = (int)number3;
            }
            return minim;
        }

        public int FindMaximum(int number1, int number2)
        {
            int max;

            if (number1 > number2)
            {
                max = number1;
            }
            else
            {
                max = number2;
            }
            return max;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int max;

            if ((number1 > number2) && (number1 > number3))
            {
                max = number1;
            }
            else if ((number2 > number3) && (number2 > number1))
            {
                max = number2;
            }
            else
            {
                max = (int)number3;
            }
            return max;
        }
    }
}