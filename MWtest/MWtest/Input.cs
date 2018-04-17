﻿using System;
using System.Collections;
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
        public string datePattern { get; private set; }

        public DateTime firstDateParsed { get; private set;}
        public DateTime secondDateParsed { get; private set; }

        DateTime outFirstDate;
        DateTime outSecondDate;

        DateTimeStyles styles;

        //int requiredArgumentLength;

        String[] arguments;

        public void ReturnInput()
        {
            Console.WriteLine();
            arguments = Environment.GetCommandLineArgs();
            styles = DateTimeStyles.None;

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            List<string> datePatterns = new List<string>();
            List<string> correctDatePatterns = new List<string>();

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
                
                firstDate = arguments[1];
                secondDate = arguments[2];
            }
            for (int i = 0; i < cultures.Length; i++)
            {
                if (DateTime.TryParseExact(firstDate, cultures[i].DateTimeFormat.ShortDatePattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out outFirstDate))
                {             
                    datePatterns.Add(cultures[i].DateTimeFormat.ShortDatePattern);
                   // Console.WriteLine(cultures[i].DateTimeFormat.ShortDatePattern);                    
                }
                if (i == (cultures.Length - 1) && datePatterns.Count == 0)
                {
                    Console.WriteLine("Unable to parse '{0}' to DateTime", firstDate);
                    Environment.Exit(1);
                }
            }

            //Console.WriteLine("==============================================");

            for (int i = 0; i < datePatterns.Count; i++)
            {
                if (DateTime.TryParseExact(secondDate, datePatterns[i], CultureInfo.InvariantCulture, styles, out outSecondDate))
                {
                    correctDatePatterns.Add(datePatterns[i]);
                   // Console.WriteLine(datePatterns[i]);
                }
                if (i == (datePatterns.Count - 1) && correctDatePatterns.Count == 0)
                {
                    Console.WriteLine("Unable to parse '{0}' to any formats which are fine for '{1}'.\nPlease provide dates with the same format.", secondDate, firstDate);
                    Environment.Exit(1);
                }
            }

            datePattern = correctDatePatterns[0];
            
            DateTime.TryParseExact(firstDate, datePattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out outFirstDate);
            firstDateParsed = outFirstDate;

            DateTime.TryParseExact(secondDate, datePattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out outSecondDate);
            secondDateParsed = outSecondDate;
        }
    }
}

