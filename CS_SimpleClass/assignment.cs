using System;

namespace CS_SimpleClass
{
    class assignment
    {
        static void Main(string[] args)
        {
            operations op = new operations();
            double rPower = op.calPower();
            Console.WriteLine($"Power of given number {rPower}");
            
            int rFactorial = op.calFactorial(0);
            Console.WriteLine($"Factorial of given number is {rFactorial}");

            double rTrignometry = op.trignomerty("cod", 120);
            Console.WriteLine($"Trignometry value for entered values is: {rTrignometry}");


        }
        
    }
}
