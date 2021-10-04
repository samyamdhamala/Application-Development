using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class NestedIfElse
    {
        public void NestedIfElseStatement()
        {
            int protectedPrivateValue = 9;

            if (protectedPrivateValue == 9)
            {
                Console.WriteLine("Is 9");
                if (protectedPrivateValue / 2 == 3)
                {
                    Console.WriteLine("Is Divisible By 3");
                }
                else
                {
                    Console.WriteLine("Is Not Divisible by 3");
                }
            }
            else
            {
                Console.WriteLine("Is other");
                Console.ReadLine();

            }
        }
    }
}
