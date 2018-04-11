using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWtest
{

    class Output
    {
        Input input = new Input();

        DateTime firstDate;
        DateTime secondDate;

        public void CalculateAndOutput()
        {
            input.GetDates();


            Console.WriteLine(firstDate + "\n" + secondDate);
        }
    }
}
