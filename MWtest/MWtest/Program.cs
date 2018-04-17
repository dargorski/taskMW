using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWtest
{
    class Program
    {
        static public Input input = new Input();
        static public Output output = new Output();

        static void Main(string[] args)
        {
            input.ReturnInput();

            try
            {
                output.CalculateAndOutput(input.firstDateParsed, input.secondDateParsed, input.cultureInfoName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught", e);
            }

        }
    }
}
