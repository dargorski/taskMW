using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWtest
{
    class Input
    {
        //private DateTime firstDate;
        //private DateTime secondDate;
        string firstDate;
        string secondDate;

        DateTime firstDateParsed;
        DateTime secondDateParsed;

        public void ReturnInput()
        {

            
            Console.WriteLine();
            String[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length > 1)
            {
                firstDate = arguments[1];
            } else
            {
                Console.WriteLine("Did not receive any arguments");
                return;
            }

            if(arguments.Length > 2)
            {
                secondDate = arguments[2];
            } else
            {
                Console.WriteLine("Did not receive second argument");
                return;
            }

            if(DateTime.TryParse(firstDate, out firstDateParsed))
            {
                Console.WriteLine(firstDateParsed);
            } else
            {
                Console.WriteLine("Couldn't parse 1st argument to DateTime");
            }

            if (DateTime.TryParse(secondDate, out secondDateParsed))
            {
                Console.WriteLine(secondDateParsed);
            }
            else
            {
                Console.WriteLine("Couldn't parse 2st argument to DateTime");
            }




        }
    }
}
