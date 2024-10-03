using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module2
{
    public class Ex1 {}
    public class Ex2 : Ex1 {}
    class Box
    {
        private int length;
        private int width;
        private int height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(), box1.GetWidth() + box2.GetWidth(), box1.GetHeight() + box2.GetHeight());
        }
    }

    class Program
    {
        private static void Main2()
        {
            int i = 0;
            i = 5;
            Console.WriteLine(++i); // before
            i = 5;
            Console.WriteLine(i++); // after
            i = 5;
            Console.WriteLine(--i);
        
        
            Console.WriteLine((int)5.5f); // 5

            Console.WriteLine(Math.Abs(-3)); // 3

            Console.WriteLine(Math.Round(1.7f)); // 2
            Console.WriteLine(Math.Ceiling(2.2f)); // 3
            Console.WriteLine(Math.Floor(4.9f)); // 4

            char char1 = 'a';
            char char2 = '\n';
            Console.WriteLine(char1 + char2); // a

            string s1 = "abc";
            string s2 = "abc";
            Console.WriteLine(string.Equals(s1, s2)); // true // s1 == s2 also works
            
            string @if = "Hello World";
            Console.WriteLine(@"\n"+$" {@if}");

            string example = "abc";
            Console.WriteLine(example.Contains("bc")); // true
            Console.WriteLine(example.Substring(1, 2)); // bc

            Console.WriteLine("Bobby said \"Go write some code\""); // Bobby said "Go write some code"
            Console.WriteLine("\'a\\b\'"); // a\b
            Console.WriteLine("\a"); // bip sound
            Console.WriteLine("\rHello World"); // \nHello World
            Console.WriteLine("Hello \t World"); // Hello     World

            int price = 100;
            Console.WriteLine(string.Format("The item costs {0:C}", price));

            int price1 = 50;
            int price2 = 150;
            int price3 = 200;
            Console.WriteLine(string.Format("The price of item 1 is: {0:C}, \nThe price of item 2 is: {1:C}, \nAnd the price of item 3 is: {2:C}", price1, price2, price3));

            float percent = 0.5f;
            Console.WriteLine(string.Format("The task is {0:p} complete", percent));

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World");
            for(i = 0; i < 4; i++)
            {
                stringBuilder.Append(" nice to see you");
            }
            string s = stringBuilder.ToString();
            Console.WriteLine(s);
            stringBuilder.Clear();
            s = stringBuilder.ToString();
            Console.WriteLine(s);

           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Hello World");
           sb.AppendLine("Hello World");
           Console.WriteLine(sb.ToString());
           sb.Clear();
           sb.Append("This is a string with some spaces");
           sb.Replace(" ", "_");
           sb.Insert(3, "4");
           sb.Remove(3, 1);
           Console.WriteLine(sb.ToString());
        
        
            string ss1 = "The quick brown fox jumped over the lazy dog";
            string[] sArray = ss1.Split(' ');
            
            bool example1 = true;
            example1 &= true;
            Console.WriteLine(example.ToString());

            bool flag = false;  
            List<int> intList = new List<int>() { 1, 2, 3};
            foreach(int i1 in intList)
            {
                    if(i1 == 3)
                    {
                        flag = true;
                    }
                    if(flag)
                    {
                        PrintMessage("3 was found!");
                    }
            }

            object? o = null;
            bool? example1_ = null;
            int? example2 = null;
            char? example3 = null;
            Console.WriteLine(o.GetType().ToString(), example1_.ToString(), example2.ToString(), example3.ToString());
        
        
            //Implicit convertion
            int num = 3;
            float f = num;

            //Explicit Convertion
            f = 1.5f;
            int example_ = (int)f;

            //Boxing and Unboxing
            example_ = 1;
            object o1 = example;
            int example2_ = (int)o1;

            dynamic ex = 1; // só recebe um tipo depois de ser executado

            int i_ = 200;
            Console.WriteLine(i_);
            ChangeValue(i_);
            Console.WriteLine(i_);

            Person p = new Person();
            p.Name = "Old Person";
            ChangeReferenceType(p);
            PrintMessage(p.Name);
        
            
        }

        static void PrintMessage(string message)
    {
        {
            Console.WriteLine(message);
        }
    }
    static void ChangeReferenceType(Person person)
    {
        person.Name = "New Name";
    }
    static void ChangeValue(int num)
    {
       num = 500;
       Console.WriteLine(num);
    }

    public class Person
    {
    public string? Name;
    }
    }   
}