using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class ForEach
    {
        public void ForEachList()
        {
            //Declaring a new list
            List<String> cityList = new List<String>();

            // Pushing data to teh list
            cityList.Add("Biratnagar");
            cityList.Add("Itahari");
            cityList.Add("Damak");
            cityList.Add("Dharan");
            cityList.Add("Kankai");
            cityList.Add("Bhaunne");
            cityList.Add("Pathri");

            foreach (var city in cityList)
            {
                Console.WriteLine(String.Format("The city name is {0}.", city));
            }
        }

        public void ForEachArray()
        {
            string[] places = { "Urag", "Maple", "Lara", "Lunar", "Bele", "Nemje", "Dori", "Manthana", "Roen-phet", "Mira" };

            foreach (var place in places)
            {
                Console.WriteLine(String.Format("The place is {0}", place));
            }
        }
    }
}
