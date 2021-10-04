using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class IfElseStatement
    {
        public void IfStatement()
        {
            int protectedPrivateValue = 10;

            if (protectedPrivateValue == 11)
            {
                Console.WriteLine("Is 11");
            }
            else
            {
                Console.WriteLine("Is Other");
                Console.ReadLine();
            }
        }
    }
}
