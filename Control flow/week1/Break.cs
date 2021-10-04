using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Break
    {
        public void breakFunction()
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(String.Format("The Number is {0}.", i));
                i++;
                if (i == 25)
                {
                    break;
                }
            }
        }
    }
}
