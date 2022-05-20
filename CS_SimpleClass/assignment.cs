using System;

namespace CS_SimpleClass
{
    class assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            operations op = new operations();
            int result = op.calPower(2, 2);
            Console.WriteLine($"Raise to values are: {result}");
        }
        
    }
}
