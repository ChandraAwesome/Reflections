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
            int N = Convert.ToInt32(Console.ReadLine());

            int closenumber = N;

            if(N<0)
            {
                closenumber = -closenumber;
            }
            while(true)
            {
                closenumber++;

                if(FindEvenDigitNumber(closenumber))
                {
                    break;
                }
            }

            if(N<0)
            {
                closenumber=-closenumber;
            }
            Console.WriteLine("The Closest Even Digit Number of the given input is "+closenumber);
        }

        private static bool FindEvenDigitNumber(int number)
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
