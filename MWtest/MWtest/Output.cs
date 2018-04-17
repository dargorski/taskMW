using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWtest
{

    class Output
    {
        string firstDateFormatted, secondDateFormatted;

        public void CalculateAndOutput(DateTime firstDate, DateTime secondDate, string datePattern)
        {
            Console.WriteLine(datePattern);

            //Console.WriteLine(firstDate.ToString() + " " + secondDate.ToString());

            String[] dateFormats = { "dd.MM.yyyy", "dd.MM", "dd" };
            TimeSpan timeSpan = secondDate - firstDate;
            //Console.WriteLine(timeSpan.TotalDays);

            if(timeSpan.TotalDays < 0)
            {
                Console.WriteLine("First date is greater than second date.");
                Environment.Exit(1);
            }
            if(timeSpan.TotalDays == 0)
            {
                Console.WriteLine(secondDate.ToString(dateFormats[0]));
                Environment.Exit(1);
            }

            secondDateFormatted = secondDate.ToString(dateFormats[0]);

            if (firstDate.Year != secondDate.Year)
            {
                firstDateFormatted = firstDate.ToString(dateFormats[0]);
                
            } else if (firstDate.Month != secondDate.Month)
            {
                firstDateFormatted = firstDate.ToString(dateFormats[1]);
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
