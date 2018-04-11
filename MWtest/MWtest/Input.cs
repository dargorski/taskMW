using System;
using System.Collections.Generic;
using System.Globalization;
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

        DateTimeStyles styles;
        CultureInfo culture;

        String[] arguments;

        public void ReturnInput()
        {


            Console.WriteLine();
            arguments = Environment.GetCommandLineArgs();
            culture = new CultureInfo("de-DE");
            styles = DateTimeStyles.AssumeLocal;
            
            
            if (arguments.Length < 3)
            {
                Console.WriteLine("Did not receive any arguments");
                return;
            }
            if (arguments.Length > 3)
            {
                Console.WriteLine("Too many arguments. \nPlease enter two dates.");
                return;
            }

            if (arguments.Length == 3)
            {
                firstDate = arguments[1];
                secondDate = arguments[2];
            }


            if (DateTime.TryParse(firstDate,culture,styles, out firstDateParsed))
            {
                Console.WriteLine(firstDateParsed);
            }
            else
            {
                Console.WriteLine("Couldn't parse 1st argument to DateTime");
                return;
            }

            if (DateTime.TryParse(secondDate, culture, styles, out secondDateParsed))
            {
                Console.WriteLine(secondDateParsed);
            }
            else
            {
                Console.WriteLine("Couldn't parse 2nd argument to DateTime");
                return;
            }




        }
    }
}

