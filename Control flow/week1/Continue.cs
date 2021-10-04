using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Continue
    {
        public void continueFunction()
        {

            // For loop
            for(int i = 0; i < 25; i++)
            {
                if (i == 12)
                {
                    continue;
                }

                Console.WriteLine(String.Format("For Loop {0}.", i));
            }
        }
    }
}
