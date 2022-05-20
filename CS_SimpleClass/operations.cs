using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleClass
{
    class operations
    {
        public int calPower(int a, int b)
        {
            if (b == 0)

                return 1;
            else
                return a * calPower(a, b - 1);
        }
    }
}
