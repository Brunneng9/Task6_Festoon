using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Festoon
{
    class Helper
    {
        public static int EnterValue()
        {
       
            Console.WriteLine("Enter number of bulbs in festoon");
            int enteredValue;
            while (true)
            {
               
                if (int.TryParse(Console.ReadLine(), out enteredValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Value should be integer");
                }
            }
            return enteredValue;
        }
    }
    
}
