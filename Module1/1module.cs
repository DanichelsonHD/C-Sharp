using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Module1
{
    public class Ex1 {}
    public class Ex2 : Ex1 {}

    internal class Box
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

    internal class Program
    {
        private static void Main1()
        {
                System.Diagnostics.Debug.WriteLine("Hello World");
                PrintMessage("Hello World");

            
                
                int x = 5;
                //float y = 3.0f;
                //string string1 = "I eat pizza";
                //char char1 = 'a';
                bool complete = false;
                
                bool started = true;
                x = 0;

                if(complete)
                {
                    x = 5;
                }
                else if(started)
                {
                    x = 3;
                }
                else
                {
                    x = 1;
                }


                List<string> collection = new List<string>() {"a", "b", "c"};
                for(int i = 0; i < collection.Count; i++)
                {
                    Console.WriteLine(collection[i]);
                }

                int j = 3;
                while(j > 0)
                {
                    Console.WriteLine("Loading");
                    j--;
                }
                
                PrintMessage("Hello World, this is a Function");
            
            
                int a = 10;
                int b = 4;
                Console.WriteLine(a%b); // 2

                Ex2 ex2Object = new Ex2();
                bool b1 = ex2Object is Ex1;
                Console.WriteLine(b1); // True

                string s1 = "abc";
                object obj1 = s1;
                string? s2 = obj1 as string;
                Console.WriteLine(s2); // abc

                x = 5;
                int value = 1;
                var isGreater = x > value ? true : false;
                Console.WriteLine(isGreater); // True
            
            
                object? obj = null;
                object obj2 = obj ?? new object();
                //Console.WriteLine(obj2); // System.Object

                //Console.WriteLine(sizeof(int));
            

                //Console.WriteLine(typeof(int)); // System.Int32

                Box box1 = new Box(2, 2, 2);
                Box box2 = new Box(2, 2, 2);
                Box box3 = box1 + box2;
                //Console.WriteLine(box3.GetLength().ToString(), box3.GetWidth().ToString(), box3.GetHeight().ToString()); // 4

                Type sType = typeof(string);
                Console.WriteLine(sType);
            
        }

        private static void PrintMessage(string message)
    {
        {
            Console.WriteLine(message);
        }
    }
    }   
}