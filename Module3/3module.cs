using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module3
{
    class Program
    {
        private static void Main3()
        {
            Console.WriteLine(DateTime.Now);
            DateTime dateTime = new DateTime(2020, 1, 19);
            Console.WriteLine(dateTime);

            TimeSpan timeSpan = new TimeSpan(1, 2, 0);
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.Seconds);

            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yy HH:mm:ss"));
        
        }
    }   
}