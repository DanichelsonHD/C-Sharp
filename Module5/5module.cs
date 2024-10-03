using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module5
{
    class Program
    {
        private static void Main5()
        {
        PrintMessage("Type some text: ");
        string? userInput = Console.ReadLine();
        //PrintMessage(userInput);
        PrintMessage("g = green, r = red, b = blue, w = white");
        int x = Console.Read();
        char uI = Convert.ToChar(x);
        while(uI != 'z')
        {
            switch(uI)
            {
                case 'g':
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 'r':
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 'b':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 'w':
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
            Console.Clear();
            PrintMessage("g = green, r = red, b = blue, w = white");
            x = Console.Read();
            uI = Convert.ToChar(x);
        }
        

        ConsoleKeyInfo keyInfo;
        Console.TreatControlCAsInput = true;
        do{
            keyInfo = Console.ReadKey();
            if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0) 
                PrintMessage("ALT+");
            if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0) 
                PrintMessage("SHIFT+");
            if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0) 
                PrintMessage("CTRL+");

        } while (keyInfo.Key != ConsoleKey.Escape);
        
        Console.WriteLine("\n Please enter a number: ");
            do
            {
                string? userInput1 = Console.ReadLine();
                int number;

                if(!int.TryParse(userInput1, out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered an invalid Input!");
                    Console.ResetColor();
                    Console.WriteLine("\n Please enter a number: ");
                } else
                {
                    Console.WriteLine("\n Thanks! Enter another number: ");
                }
            } while (!true);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            if(!File.Exists(path)) File.Create(path);

            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");
            fs.Write(info, 0, info.Length);
            fs.Close();

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();
            Console.WriteLine("In Example.txt, is write: " + fileText);

        }

        static void PrintMessage(string message)
    {
        {
            Console.WriteLine(message);
        }
    }
    }   
}