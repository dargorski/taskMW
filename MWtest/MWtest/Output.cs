using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWtest
{

    class Output
    {
        string firstDateFormatted, secondDateFormatted;

        public void CalculateAndOutput(DateTime firstDate, DateTime secondDate, string cultureInfoName)
        {
           // Console.WriteLine(datePattern);

            //Console.WriteLine(firstDate.ToString() + " " + secondDate.ToString());

            String[] dateFormats = { "dd.MM.yyyy", "dd.MM", "dd" };
            TimeSpan timeSpan = secondDate - firstDate;
            //Console.WriteLine(timeSpan.TotalDays);
            CultureInfo ci = new CultureInfo(cultureInfoName);

            if(timeSpan.TotalDays < 0)
            {
                Console.WriteLine("First date is greater than second date.");
                Environment.Exit(1);
            }

            secondDateFormatted = secondDate.ToString("d", ci);

            if (timeSpan.TotalDays == 0)
            {
                Console.WriteLine(secondDateFormatted);
                Environment.Exit(1);
            }

            if (firstDate.Year != secondDate.Year)
            {
                firstDateFormatted = firstDate.ToString("d", ci);
                
            } else if (firstDate.Month != secondDate.Month)
            {
                firstDateFormatted = firstDate.ToString("M", ci);
            } else
            {
                firstDateFormatted = firstDate.ToString(dateFormats[2]);
            }      

            Console.WriteLine(firstDateFormatted +  " - " + secondDateFormatted);
            //Console.WriteLine(firstDateFormatted);
            //Console.WriteLine(secondDate.ToString(dateFormats[0]));

        }
    }
}
