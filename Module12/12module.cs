using System;

namespace Module12
{
    public class Program1
    {
        delegate void Print();

        public static void Main1(string[] args)
        {
            #region
            Console.WriteLine("Hello World");
            #endregion

            //Print helloWorld = HelloWorld;
            Print helloWorld = GoodbyeWorld;
            helloWorld();

            Print print = null;
            print += HelloWorld;
            print += GoodbyeWorld;
            print();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void GoodbyeWorld()
        {
            Console.WriteLine("Goodbye World");
        }
    }

    public class Program2
    {
        private static event EventHandler evt;

        public static void HandleEvent (object sender, EventArgs evtArgs)
        {
            Console.WriteLine("Hello World");
        }

        public static void Main2(string[] args)
        {
           evt += HandleEvent;
           evt += (sender, evtArgs) => {
            Console.WriteLine("Goodbye World");
           };
           evt.Invoke(null, new EventArgs());
        }

        ~Program2()
        {
            evt -= HandleEvent;
        }
    }

    public class Program3
    {
        private static Action<int, int> action;

        static void HandleAction(int int1, int int2)
        {
            Console.WriteLine("Sum: " + (int1 + int2).ToString());
        }
        
        public static void Main3(string[] args)
        {
            action += HandleAction;
            action.Invoke(2, 3);
        }
    }

    public class Fibonacci4
    {
        static int fib (int n)
        {
            if (n == 0 || n == 1) { return n; }

            return fib(n - 1) + fib(n - 2);
        }

        static int fib2 (int n)
        {
            if (n == 0 || n == 1) { return n; }
            
            int sLast = 0;
            int last = 1;
            int curPos = 2;

            while (curPos <= n)
            {
                int temp = last;
                last = last + sLast;
                sLast = temp;
                curPos++;
            }

            return last;

        }
        
        public static void Main4(string[] args)
        {
            Console.WriteLine(fib(11));
            Console.WriteLine(fib2(11));
        }
    }

    public class TowerOfHanoi
    {
        public static void Main5(string[] args)
        {

        }

        void MoveDisk (int n, Stack<int> tower1, Stack<int> tower2, Stack<int> tower3)
        {
            if (n == 1)
            {
                tower3.Push(tower1.Pop());
                return;
            }

            MoveDisk(n-1, tower1, tower2, tower3);
            tower3.Push(tower1.Pop());
            MoveDisk(n-1, tower2, tower3, tower1);
        }
    }
}