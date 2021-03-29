using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using _03_RangeException.Models;

namespace _03_RangeException
{
    class Tests
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

            //1.Check DateTime.
            var dateTimeRangeException = new InvalidRangeException<DateTime>("1.1.1980", "12.31.2013");
            var dateTimeInRange = DateTime.Parse("12.31.2013");
            var dateTimeOutOfRange = DateTime.Parse("12.31.2020");

            Console.WriteLine("1.Check DateTime:");
            dateTimeRangeException.CheckRange(dateTimeInRange);
            Console.WriteLine(dateTimeRangeException.ErrorMessage);
            dateTimeRangeException.CheckRange(dateTimeOutOfRange);
            Console.WriteLine(dateTimeRangeException.ErrorMessage);

            //2.Check integer range.
            var intRangeException = new InvalidRangeException<int>(1, 100);
            var firstIntInRange = 45;
            var secondIntOutOfRange = 130;

            Console.WriteLine("\n" + "2.Check integer range:");
            intRangeException.CheckRange(firstIntInRange);
            Console.WriteLine(intRangeException.ErrorMessage);
            intRangeException.CheckRange(secondIntOutOfRange);
            Console.WriteLine(intRangeException.ErrorMessage);

            //Bonus - test string range.
            var stringRangeException = new InvalidRangeException<string>("B", "D");
            var firstStrInRange = "C";
            var secondStrOutOfRange = "Z";

            Console.WriteLine("\n" + "Bonus - test string range:");
            stringRangeException.CheckRange(firstStrInRange);
            Console.WriteLine(stringRangeException.ErrorMessage);
            stringRangeException.CheckRange(secondStrOutOfRange);
            Console.WriteLine(stringRangeException.ErrorMessage);
        }
    }
}
