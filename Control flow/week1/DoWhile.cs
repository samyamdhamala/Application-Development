using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class DoWhile
    {
        public void DWhile(int range)
        {
            int i = 0;
            do
            {
                Console.WriteLine(String.Format("The number is {0}", i));
                i++;
            } while (i < range);
        }
    }
}
