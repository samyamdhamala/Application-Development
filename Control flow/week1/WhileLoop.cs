using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class WhileLoop
    {
        public void Wloop(int range)
        {
            int i = 0;
            while (i < range)
            {
                Console.WriteLine(String.Format("The number is {0}", i));
                i++;
            }
        }
    }
}
