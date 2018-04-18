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
        string datePatternForDayAndMonth;

        public void CalculateAndOutput(DateTime firstDate, DateTime secondDate, string datePattern)
        {
            TimeSpan timeSpan = secondDate - firstDate;

            if (timeSpan.TotalDays < 0)
            {
                Console.WriteLine("First date is greater than second date.");
                Environment.Exit(1);
            }
            secondDateFormatted = secondDate.ToString(datePattern, CultureInfo.InvariantCulture);
            firstDateFormatted = firstDate.ToString(datePattern, CultureInfo.InvariantCulture);
            if (timeSpan.TotalDays == 0)
            {
                Console.WriteLine(secondDateFormatted);
                Environment.Exit(1);
            }

            datePatternForDayAndMonth = datePattern
                    .Replace("-yyyy", "")
                    .Replace("yyyy-", "")
                    .Replace("-yyyy", "")
                    .Replace("yyyy.", "")
                    .Replace(".yyyy", "")
                    .Replace("/yyyy", "")
                    .Replace("yyyy/", "")
                    .Replace(".yy", "")
                    .Replace("yy.", "")
                    .Replace("/yy", "")
                    .Replace("yy/", "")
                    .Replace("yy-", "")
                    .Replace("-yy", "");

            if (datePattern.IndexOf('y') != 0)
            {
                if (firstDate.Year != secondDate.Year)
                {
                    firstDateFormatted = firstDate.ToString(datePattern, CultureInfo.InvariantCulture);

                }
                else if (firstDate.Month != secondDate.Month)
                {
                    firstDateFormatted = firstDate.ToString(datePatternForDayAndMonth, CultureInfo.InvariantCulture);
                }
                else
                {
                    firstDateFormatted = firstDate.Day.ToString();
                }
            }
            if(datePattern.IndexOf('y') == 0)
            {
                if (firstDate.Year != secondDate.Year)
                {
                    secondDateFormatted = secondDate.ToString(datePattern, CultureInfo.InvariantCulture);

                }
                else if (firstDate.Month != secondDate.Month)
                {
                    secondDateFormatted = secondDate.ToString(datePatternForDayAndMonth, CultureInfo.InvariantCulture);
                }
                else
                {
                    secondDateFormatted = secondDate.Day.ToString();
                }
            }

            Console.WriteLine(firstDateFormatted + " - " + secondDateFormatted);
        }
    }
}
