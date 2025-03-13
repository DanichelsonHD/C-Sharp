using System;
using Log = System.Console;

namespace Module14.System
{
    public class Program1
    {
        public static void Main1(string[] args)
        {
            Log.WriteLine("Hello World");
        }
    }

    public class Program2
    {
        public static void Main2(string[] args)
        {
            //System.Diagnostics.Debug.WriteLine("Hello World");
            global::System.Diagnostics.Debug.WriteLine("Hello World");
        }
    }
}