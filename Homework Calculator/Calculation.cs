using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Calculator
{
    public class Calculation : ICalculation
    {
      
        public void Calculate(int num1, string Operation, int num2)
        {
            if (Operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            if (Operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            if (Operation == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            if (Operation == "/")
            {
                Console.WriteLine(num1 / num2);
            }

          
        }
    }



    public interface ICalculation
    {
        void Calculate(int num1, string Operation, int num2);
    }
}
