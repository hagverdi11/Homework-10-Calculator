using System;

namespace Homework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();



            //Type your digits 


            calculation.Calculate(16, "/", 8);
            calculation.Calculate(16, "*", 8);
            calculation.Calculate(16, "-", 8);
            calculation.Calculate(16, "+", 8);

        }
    }
}
