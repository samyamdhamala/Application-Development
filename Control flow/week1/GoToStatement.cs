using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class GoToStatement
    {
        public void GTStatement()
        {
            // Looping for a while until we reach the desired number to exit the loop and go the
            // Labelled point in the code
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("You are at {0}, Position", i));
                if (i == 5)
                {
                    goto ComeHere;
                }
            }

        //Creating a named label to return to
        ComeHere:
            Console.WriteLine("You Reached!!");
        }
    }
}
