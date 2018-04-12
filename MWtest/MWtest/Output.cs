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

        public void CalculateAndOutput(DateTime firstDate, DateTime secondDate)
        {
            String[] dateFormats = { "dd.MM.yyyy", "dd.MM", "dd" };
            TimeSpan timeSpan = secondDate - firstDate;

            if(timeSpan.TotalDays <= 0)
            {
                Console.WriteLine("First date is greater or equal second date.");
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
