using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class SwitchCase
    {
        public void Switch(int value)
        {
            switch (value)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("The number is less then 5");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The number is less than 10 and greater than 5");
                    break;
                default:
                    Console.WriteLine("The number is greater than 10 or is equals to 5");
                    break;
            }
        }
    }
}
