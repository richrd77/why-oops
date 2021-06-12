using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_Oops
{
    class NoOOPS
    {
        public void Display()
        {
            string playerName1 = "Dhoni";
            int playerAge1 = 34;

            string playerName2 = "Kholi";
            int playerAge2 = 24;

            string playerName3 = "Zhaheer";
            int playerAge3 = 44;

            Console.WriteLine("{0} with Age {1}", playerName1, playerAge1);
            Console.WriteLine("{0} with Age {1}", playerName2, playerAge2);
            Console.WriteLine("{0} with Age {1}", playerName3, playerAge3);
        }
    }
}
