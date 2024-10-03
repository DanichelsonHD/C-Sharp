using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace Module7
{
    public class Program : IExample, ISecondExample
    {
        public static void Main7(string[] args)
        {
            
        }

        public void Example()
        {
            Debug.WriteLine("Hello World");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }

    interface IExample
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }

    interface ISecondExample {   }

    public class Program2 : INotifyPropertyChanged, IComparable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name
        { 
            get
            {
                return Name;
            } 
            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
        public int exampleLength;
        Program2 ex1 = new Program2() { exampleLength = 2 };

        public int CompareTo(object? obj)
        {
            Program2 ex2 = (Program2)obj;
            if (ex1.exampleLength == ex2.exampleLength)
            {
                return 0;
            } 
            else if (ex1.exampleLength > ex2.exampleLength)
            {
                return 1;
            } 
            else
            {
                return -1;
            }
        }
    }
    class Employee
    {
        public int id;
    }

    class Program3 : IComparer
    {
        public static void Main(string[] args)
        {
            
        }

        public int Compare(object? x, object? y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }
    }
}