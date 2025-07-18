using System;

namespace Module17
{
    class Program1
    {   
        public static void Main1(string[] args)
        {
            Car.Start();
            Car.Drive();
            Car.Stop();
        }
    }

    public static class Car
    {
        static int speed;
        static string color;
        static float price;
    
        public static void Start()
        {
            Console.WriteLine("Car started");
        }

        public static void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public static void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }


    class Program2
    {   
        private static int number1 = 3;
        private static int number2 = 5;

        public static int MultiplyWithExtras(int num1, int num2)
        {
            return num1 * num2 + number1 + number2;
        }
    }

    public class MainClass2
    {
        public static void Main2(string[] args)
        {
            Program2.MultiplyWithExtras(1, 2);
        }
    }


    public abstract class AbstractClass {}

    public class Class3 : AbstractClass
    {
        public static void Main3(string[] args)
        {
            Class3 example = new Class3();
        }
    }


    public class Class4 { // sealed faz com que a classe não possa ser herdada
        public int myInt; // protected faz com que a variável só possa ser acessada dentro da classe e nas classes que herdam dela
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }
    
    public class Class4b : Class4 {}
    
    public class Class4c
    {
        public static void Main4(string[] args)
        {
            Class4b obj = new Class4b();
            obj.Print();
            int myInt2 = obj.myInt;
        }
    }


    public class Class5a
    {
        public virtual void Example()
        {
            Console.WriteLine("Class 5A's Example method");
        }
    }

    class Class5b : Class5a
    {
        public override void Example()
        {
            Console.WriteLine("Class 5B's Example method");
        }
    }

    class Class5c
    {
        public static void Main5(string[] args)
        {
            Class5a obj = new Class5b();
            obj.Example();
        }
    }


    public class ExampleClass {}
    
    public class DerivedExampleClass : ExampleClass {}

    public class MainClass 
    {
        public static void ExampleMethod(ExampleClass ex) 
        {
            Console.WriteLine(ex.GetType().Name);
        }

        public static void Main6(string[] args)
        {
            ExampleClass exampleClass = new DerivedExampleClass();
            DerivedExampleClass derivedClass = new DerivedExampleClass();

            ExampleMethod(exampleClass);
            ExampleMethod(derivedClass);
        }
    }

    class Program7
    {   
        public static void Main7(string[] args)
        {
            PartialClass partialClass = new PartialClass();

            partialClass.Method1();
            partialClass.Method2();
            partialClass.Method3();
        }
    }

    public partial class PartialClass
    {
        public void Method1() {
            Console.WriteLine("Method1 called");
        }
    }


    class Program8
    {   
        public static void Main8(string[] args)
        {
            ExampleClassWithIndexer example = new ExampleClassWithIndexer();
            example[0] = "Hi";
            example[1] = 2;
            example[2] = true;
            example[3] = 1.0f;

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(example[i]);
            }
        }
    }

    public class ExampleClassWithIndexer
    {
        private string[] dataArray = new string[100];
        public object this[int index]
        {
            get { 
                if(index < 0 || index >= dataArray.Length)
                {
                    Console.WriteLine("Index out of range");
                    return new Object();
                } else
                {
                    return dataArray[index];
                }
             }
            set { 
                if(index < 0 || index >= dataArray.Length)
                {
                    Console.WriteLine("Index out of range");
                } else
                {
                    dataArray[index] = value.ToString();
                }
             }
        }
    }
}