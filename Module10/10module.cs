using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Module7
{
    public class Program10 : IExample, ISecondExample
    {
        public static void Main10(string[] args)
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

    class Program3 : IComparer, IEquatable<Program3>
    {
        public int Compare(object? x, object? y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }

        public string? exampleData;

        public bool Equals(Program3? other)
        {
            if (other == null)
            {
                return false;
            }

            return exampleData.GetHashCode() == other.exampleData.GetHashCode();
        }
    }

    public class Officer
    {
        public Guid Id
        {
            get { return Id; }
            set { Id = value; }
        }
    }
    public class Program4 : IEqualityComparer<Officer>
    {
        public bool Equals(Officer? x, Officer? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();
        }
    }

    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Money bill in bills)
            {
                if(bill == null) { break; }

                yield return bill;
            }
        }
    }

    class Money
    {
        public int amount;
    }

    public class Program5
    {
        public static void Main7_5(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });

            foreach(Money money in wallet)
            {
                Console.WriteLine("Bill: " + money.amount);
            }
        }
    }

    class Program6 : IEnumerator
    {
        List<object> items = new List<object>();
        int current;

        public object Current => items[current];

        public bool MoveNext()
        {
            if (items.Count == 0 || items.Count <= current) { return false; }
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }

    /*class Program7 : ICollection
    {
        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }*/

    abstract class Animal 
    { 
        public abstract void Run(int speed);
    }
    class Dog : Animal 
    {
        public override void Run(int speed)
        {
            Console.WriteLine("Dog is running at speed: " + speed);
        }
    }

    class Program8
    {
        static void Main8(string[] args)
        {
            BaseClass childClass = new ChildClass();
            childClass.PrintMessage();
        }
    }

    class BaseClass
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Hello World");
        }
    }

    class ChildClass : BaseClass
    {
        public override void PrintMessage()
        {
            base.PrintMessage();
            Console.WriteLine("Goodbye World");
            Thread.Sleep(2000);
        }
    }

}