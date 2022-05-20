using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleClass
{
    class operations
    {
        public double calPower()
        {
            double Power = Math.Pow(10, 2);
            return Power;
        }
        public int calFactorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact*i ;
            }
            return fact;
        }
        public double trignomerty(string trignoType,double tValue)
        {
            if(trignoType == "sin")
            {
                return Math.Sin(tValue);
            }
            else if (trignoType =="Cos")
            {
                return Math.Cos(tValue);
            }
            else if (trignoType == "tan")
            {
                return Math.Tan(tValue);
            }
            else
            { 
                return 0;
            }

            
        }
    }
}
