﻿using System;
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

            //Check DateTime.
            var dateTimeRangeException = new InvalidRangeException<DateTime>("1.1.1980", "12.31.2013");
            var dateTime = DateTime.Parse("12.31.2013");
            dateTimeRangeException.CheckRange(dateTime);
            Console.WriteLine(dateTimeRangeException.ErrorMessage);
            
            //Check DateTime out of range values.
            dateTime = DateTime.Parse("12.31.2020");
            dateTimeRangeException.CheckRange(dateTime);
            Console.WriteLine(dateTimeRangeException.ErrorMessage);

        }
    }
}