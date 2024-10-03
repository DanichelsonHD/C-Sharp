using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module4
{
    class Program
    {
        private static void Main4()
        {
            /*
            if((5 < 3) == true)
            {
                PrintMessage("5 is less than 3");
            }
            else if(2 < 4)
            {
                PrintMessage("2 is less than 4");

            }
            */        
        
            int day = 2;

            switch(day)
            {
                case 1:
                    PrintMessage("Sunday");
                    break;
                case 2:
                    PrintMessage("Monday");
                    break;
                case 3:
                    PrintMessage("Tuesday");
                    break;
                case 4:
                    PrintMessage("Wednesday");
                    break;
                case 5:
                    PrintMessage("Thursday");
                    break;
                case 6:
                    PrintMessage("Friday");
                    break;
                case 7:
                    PrintMessage("Saturday");
                    break;
                default:
                    PrintMessage("Non Existent");
                    break;
            }

            string forEx = "abc";
            for(int i = 0; i < forEx.Length; i++)
            {
                PrintMessage(forEx[i].ToString());
            }

            for(int l = 0; l < 5; l++)
            {
                for(int j = 0; j < 5; j++)
                {
                    PrintMessage("l = " + l.ToString() + " j = " + j.ToString());
                }
            }

            foreach(char s in "abc")
            {
                PrintMessage(s.ToString());
            }

            int I = 0;
            do
            {
                PrintMessage(I.ToString());
                I++;
            } while(I < 5);

        }

        static void PrintMessage(string message)
    {
        {
            Console.WriteLine(message);
        }
    }
    }   
}