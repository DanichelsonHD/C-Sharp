#define CONDITION1
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module6
{
    [Serializable]
    public class Program
    {
        private string? id;
        public string Id 
        { 
            get
            {
                return id;
            } 
            set
            {
                id = value;
            }
        }

        [Obsolete("OldMethod is obsolete. Please use NewMethod instead")]
        static void OldMethod() {}
        static void NewMethod() {}

        //[Conditional("CONDITION1")]
        void ExampleMethod() {}

        private static void Main6x(String[] args)
        {
        
            Program program = new Program();
            program.Id = "1234";
            System.Diagnostics.Debug.WriteLine(program.Id);

            OldMethod();
            
            Action<string> debug = (s) => Console.WriteLine(s);
            debug("Hello World!");

            Func<int, int, int> multiply = (x, y) => { return x * y; };
            Console.WriteLine(multiply(3, 2));
            Thread.Sleep(2000);
            
            Example1();
            Example1("1");
            Example1("1", "2");
            Example1("1", "2", "3");
            
            PrintMessage();
            PrintMessage("Other Message");
        }

        static void PrintMessage(string message = "Hello World")
        {
            Console.WriteLine(message);
        }

        public static void Example1(params string[] words) 
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        int AddNumbers (int a, int b) { return a + b; }
        int AddNumbers (int a, int b, int c) { return a + b + c; }
        int AddNumbers (int a, int b, int c, int d) { return a + b + c + d; }
        //float AddNumbers (int a, int b) { return (float)(a + b); }

        ~Program() {}
        public void PrintHelloWorld()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }
    }

    public class Example2: Program
    {
        public void PrintHelloWorld() 
        { 
            System.Diagnostics.Debug.WriteLine("Hi World, how are you?");
        }
        private static void Main6Ex2(String[] args)
        {
            Example2 ex2 = new Example2();
            ex2.PrintHelloWorld();
        }
    }

    public class Example
    {
        int exampleNumber;
        string exampleName;

        public Example(int num)
        {
            exampleNumber = num;
        }

        public Example(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

        private static void Main6()
        {
            Example ex = new Example(5);
            Example ex2 = new Example(5, "John");
            Console.WriteLine(ex.exampleNumber);
            Thread.Sleep(2000);
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class ExampleAttribute : Attribute {}
    class Example3
    {
        [ExampleAttribute]
        public object? exampleObj;
    }   
    public static class Example4
    {
        public static bool GreaterThan(this int i, int val)
        {
            return (bool)(i > val);
        }

        public static void Main6Ex3()
        {
            Console.WriteLine(2.GreaterThan(1));
        }
    }

    public static class Kitchen
    {
        static async Task CookMeat() { Console.WriteLine("Cook Meat"); }
        static async Task CookVegetables() { Console.WriteLine("Cook Vegetables"); }
        static async Task MakeBread() { Console.WriteLine("Make Bread"); }
        static async Task MakeSoup() { Console.WriteLine("Make Soup"); }
        static async Task MakeSalad() { Console.WriteLine("Make Salad"); }
        static async Task MakeDrinks() { Console.WriteLine("Make Drinks"); }
        static async void MakeDinner() 
        { 
            await CookMeat();
            await CookVegetables();
            await MakeBread();
            await MakeSoup();
            await MakeSalad();
            await MakeDrinks();
        }


        private static void MainKitchen(String[] args)
        {
            MakeDinner();
        }
    }
}