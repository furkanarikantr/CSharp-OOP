using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class FourTransactions
    {
        public void Addition(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        public void Extraction(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }

        public void Division(double number1, double number2)
        {
            double result;
            if (number1 >= number2)
            {
                result = number1 / number2;
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Division is not possible. Because first number is bigger than second number!");
            }
             
        }

        public void Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }
    }
}
