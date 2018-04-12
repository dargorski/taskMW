using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MWtest
{
    class Input
    {
        string firstDate;
        string secondDate;
        string datePattern;

        public DateTime firstDateParsed { get; private set;}
        public DateTime secondDateParsed { get; private set; }

        DateTime outFirstDate;
        DateTime outSecondDate;

        DateTimeStyles styles;
        CultureInfo culture;

        int requiredArgumentLength;

        String[] arguments;

        public void ReturnInput()
        {
            Console.WriteLine();
            arguments = Environment.GetCommandLineArgs();
            culture = new CultureInfo("de-DE");
            styles = DateTimeStyles.AssumeLocal;
            requiredArgumentLength = 10;
            datePattern = "dd.MM.yyyy";
                        
            if (arguments.Length < 3)
            {
                Console.WriteLine("Did not receive two arguments");
                Environment.Exit(1);
            }
            if (arguments.Length > 3)
            {
                Console.WriteLine("Too many arguments. \nPlease enter two dates.");
                Environment.Exit(1);
            }

            if (arguments.Length == 3)
            {
                if (arguments[1].Length != requiredArgumentLength || arguments[2].Length != requiredArgumentLength)
                {
                    Console.WriteLine("Please provide date in following format: DD.MM.YYYY");
                    Environment.Exit(1);
                }
                firstDate = arguments[1];
                secondDate = arguments[2];
            }

            if (DateTime.TryParseExact(firstDate,datePattern, culture,styles, out outFirstDate))
            {
                firstDateParsed = outFirstDate;
            }
            else
            {
                Console.WriteLine("Couldn't parse 1st argument to DateTime. \nPlease provide date in following format: DD.MM.YYYY");
                Environment.Exit(1);
            }

            if (DateTime.TryParseExact(secondDate, datePattern, culture, styles, out outSecondDate))
            {
                secondDateParsed = outSecondDate;
            }
            else
            {
                Console.WriteLine("Couldn't parse 2nd argument to DateTime. \nPlease provide date in following format: DD.MM.YYYY");
                Environment.Exit(1);
            }
        }
    }
}

