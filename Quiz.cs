using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Quiz
    {
        public static void FindtheNumber()
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());

            int nearnumber = n;

            if(n<0)
            {
                nearnumber = -nearnumber;
            }
            while(true)
            {
                nearnumber++;

                if(FindEvenDigitsinNumber(nearnumber))
                {
                    break;
                }
            }

            if(n<0)
            {
                nearnumber=-nearnumber;
            }
            Console.WriteLine("The Closest Even Digit Number of the given input is "+nearnumber);
        }

        private static bool FindEvenDigitsinNumber(int number)
        {
            foreach(char digit in number.ToString())
            {
                int Value = (int)char.GetNumericValue(digit);
                if(Value%2!=0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
