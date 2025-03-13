using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Module11
{
    class Program1
    {
        string[] strings = new string[3];

        string[] strings2 = new string[3] { "a", "b", "c" };
        string[] strings3 = new string[] { "a", "b", "c" };
        string[] strings4 = { "a", "b", "c" };
        
        static int[] array = new int[3] { 1, 2, 3 };
    
        public static void Main1(string[] args)
        {
            array[0] = 5;
            Array.Sort(array);
            foreach(int i in array)
            {
                Console.WriteLine(array[i]);
            }

            string[] array2 = new string[] { "c", "a", "b"};
            Array.Sort(array2);
            foreach(string s in array2)
            {
                Console.WriteLine(s);
            }
        }
    }

    class Program2
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2};
        public static void Main2(string[] args)
        {
            List<int> backup = new List<int>() { 1, 3, 5, 4, 2 };
            
            Console.WriteLine("Count: " + numbers.Count);
            
            numbers.Capacity = 10;
            numbers.Add(6);
        
            List<int> subList = new List<int> () { 7, 8 };
            numbers.AddRange(subList);
            numbers.Sort();
            Console.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));

            Console.WriteLine("Contains 3: " + numbers.Contains(3));
            Console.WriteLine("Contains 20: " + numbers.Contains(20));
            
            numbers.Clear();
            numbers.AddRange(backup);

            numbers.Insert(0, 9);
            List<int> subList2 = new List<int> () { 0, 1, 2};
            numbers.InsertRange(1, subList2);

            numbers.ForEach(PrintToOutputWindow);

            numbers.Clear();
            numbers.AddRange(backup);

            numbers.Remove(3);
            numbers.RemoveAt(0);
            numbers.RemoveRange(0, 3);

            numbers.AddRange(backup);
            numbers.Capacity = 10;

            Console.WriteLine("Capacity before trim: " + numbers.Capacity); // 10
            numbers.TrimExcess();
            Console.WriteLine("Capacity after trim: " + numbers.Capacity); // 5

            bool areNumbersLessThan6 = numbers.TrueForAll(x => x < 6);
            Console.WriteLine(areNumbersLessThan6);

            numbers.Reverse();

            numbers.ForEach(PrintToOutputWindow);

            numbers.Clear();
            numbers.AddRange(backup);

            Console.WriteLine(numbers.IndexOf(3));
            numbers.Add(3);
            Console.WriteLine(numbers.LastIndexOf(3));
            Console.WriteLine(numbers.FindLast(x => x < 3));

            int[] arrayOfNumbers = numbers.ToArray();

            List<object> multiTypeList = new List<object>() { 1, "a", false };

            Thread.Sleep(2000);
        }

        static void PrintToOutputWindow(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program3
    {
        public static void Main3(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("a");
            s.Push("b");
            Console.WriteLine("The stack contains " + s.Count + " elements");
            
            Console.WriteLine(IsBalanced("{[()]}").ToString());
            Console.WriteLine(IsBalanced("((()}").ToString());

        }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if(c == '}' || c == ']' || c == ')')
                {
                    stackOfClosingBraces.Push(c);
                }
            }

            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                if(inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfClosingBraces.Push(inputString[i]);
                }
            }

            if((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) %2 != 0)
            {
                return false;
            }

            while(stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if((currentClosingBrace == '}' && currentOpeningBrace == '{') || (currentClosingBrace == ']' && currentOpeningBrace == '[') || (currentClosingBrace == ')' && currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }

    class Program4
    {
        static void Main4(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {
        const int MAX = 1000;
        int top;
        object[] stack = new object[MAX];
        
        public Stack()
        {
            top = -1;
        }

        public void Push(object obj)
        {
            if(top < MAX)
            {
                stack[++top] = obj;
            }
        }

        public object Pop()
        {
            if(top >= 0)
            {
                object o = stack[top];
                top--;
                return o;
            } 
            else
            {
                return -1;
            }
        }

        public object Peek()
        {
            return stack[top];
        }
    }

    class Program5
    {
        static void Main5(string[] args) 
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }

    struct Example : INotifyPropertyChanged
    {
        string Ex;
        int Ex2;

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    class Program6
    {
        enum Weekday { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static Weekday dayOfTheWeek = Weekday.Wednesday;
        public static void Main6(string[] args)
        {
            foreach(string s in Enum.GetNames(typeof(Weekday)))
            {
                Console.WriteLine(Enum.GetName(typeof(Weekday), s));
            }

            switch(dayOfTheWeek)
            {
                case Weekday.Sunday:
                    break;
                case Weekday.Monday:
                    break;
                case Weekday.Tuesday:
                    break;
                case Weekday.Wednesday:
                    break;
                case Weekday.Thursday:
                    break;
                case Weekday.Friday:
                    break;
                case Weekday.Saturday:
                    break;
            }
        }
    }

    class Program7
    {
        public static void Main7(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");
            dictionary.Add("key4", "value4");
            Console.WriteLine(dictionary.Count);

            dictionary.Remove("key4");
            Console.WriteLine(dictionary.Count);

            if(!dictionary.ContainsKey("key4")) { dictionary.Add("key4", "value4"); }


            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine(key + " = " + dictionary[key]);
            }

            string value = "";
            dictionary.TryGetValue("key1", out value);

            dictionary.Clear();
        }
    }

    class Program8
    {
        public static void Main8(string[] args)
        {
            HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
            HashSet<string> letters2 = new HashSet<string>() { "d", "e", "f" };
            HashSet<string> letters3 = new HashSet<string>() { "a", "b" };


            letters1.UnionWith(letters2); // Unify
            foreach (string s in letters1)
            {
                Console.WriteLine(s);
            }

            letters1.IntersectWith(letters3); // Only letters that are present in both
            foreach (string s in letters1)
            {
                Console.WriteLine(s);
            }

            letters1.Add("c");
            letters1.ExceptWith(letters3); // Only letters that aren't present in the second list
            letters1.SymmetricExceptWith(letters2); // Same of the one up, but works in both ways
            foreach (string s in letters1)
            {
                Console.WriteLine(s);
            }
        }
    }

    class Program9
    {
        static SortedList<string, int> sortedList = new SortedList<string, int>() { {"key1", 1}, {"key2", 2}, {"key3", 3} };
        public static void Main9(string[] args)
        {
            sortedList.Capacity = 6;
            Console.WriteLine("The sorted list's capacity is: " + sortedList.Capacity);

            foreach (string key in sortedList.Keys)
            {
                Console.WriteLine(key);
            }
            
            sortedList.Add("key4", 4);
            sortedList.Remove("key1");
            
            foreach (int value in sortedList.Values)
            {
                Console.WriteLine(value);
            }

            if (sortedList.ContainsKey("key2") && sortedList.ContainsValue(2)) 
            {
                SortedList<string, int> sl = sortedList;
                for (int i = 0; i < sl.Keys.Count; i++)
                {
                    Console.WriteLine(sl.IndexOfKey(sl.Keys[i]));
                }
                
                sortedList.Clear();
            }
        }
    }

    class Program10
    {
        static SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>() 
        {
            {"key1", "value1"},
            {"key2", "value2"},
            {"key3", "value3"}
        };

        public static void Main10(string[] args)
        {
            sortedDictionary.Add("key4", "value4");
            Console.WriteLine(sortedDictionary.Comparer.ToString());

            if (sortedDictionary.ContainsKey("key1")) { }
            if (sortedDictionary.ContainsValue("value1")) { }

            string value = string.Empty;
            sortedDictionary.TryGetValue("key1", out value);

            sortedDictionary.Remove("key2");
            sortedDictionary.Clear();
        }
    }

    class Program11
    {
        static SortedSet<int> sortedSet = new SortedSet<int>() { 2, 4, 5 };
        public static void Main11(string[] args)
        {
            sortedSet.Add(3);
            sortedSet.Add(1);

            foreach (int i in sortedSet.Reverse())
            {
                Console.WriteLine(i);
            }

            if (sortedSet.Contains(1)) { }
            if (sortedSet.IsSubsetOf(new List<int>() { 1, 2, 3 })) { } // Is part of a major set
            if (sortedSet.IsSupersetOf(new List<int>() { 1 })) { } // The other set is part of this set

            Console.WriteLine(sortedSet.Overlaps(new List<int>() { 1, 2, 3 })); // See if one or more elements are present in both sets

            sortedSet.Remove(1);
            sortedSet.RemoveWhere(x => x > 2);

            List<int> list = new List<int>{ 6, 7, 8 };
            sortedSet.UnionWith(list);
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }

            List<int> list2 = new List<int>{ 1, 2, 3, 8 };
            //sortedSet.ExceptWith(list2); // Remove the same numbers
            sortedSet.SymmetricExceptWith(list2); // Remove the same numbers and add the different ones
            //sortedSet.IntersectWith(list); // Only the same numbers remain
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }

            sortedSet.Clear();

            for (int n = 2; n < 22; n += 2) 
            {
                sortedSet.Add(n);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(sortedSet.Max);
            Console.WriteLine(sortedSet.Min);
        }
    }

    class Program12
    {
        public static void Main12(string[] args)
        {
            // Tuple<int> tuple1 = Tuple.Create(1);
            Tuple<int> tuple1 = new Tuple<int>(1);
            Tuple<int, int> tuple2 = new Tuple<int, int>(1, 2);
            Tuple<int, int, int> tuple3 = new Tuple<int, int, int>(1, 2, 3);

            Tuple<int, string, bool> mixedTypeTuple = Tuple.Create(1, "hello world", true);
            Console.WriteLine(mixedTypeTuple.Item1);
            Console.WriteLine(mixedTypeTuple.Item2);
            Console.WriteLine(mixedTypeTuple.Item3);
        }
    }

    class Program13
    {
        public class LinkedList
        {
            public class Node
            {
                public Node next;
                public object data;
            }

            private Node root;
            
            public Node First { get { return root; } }

            public Node Last 
            { 
                get 
                {
                    Node currentNode = root;
                    if (currentNode == null)
                    {
                        return null;
                    }

                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }

                    return currentNode;
                }
            }

            public void Append (object value)
            {
                Node node = new Node { data = value };
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }

            public void Delete (Node node)
            {
                if (root == node)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while (current.next != null)
                    {
                        if (current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }

                        current = current.next;
                    }
                }
            }

        }
    
        static LinkedList<string> linkedList = new LinkedList<string>();
        public static void Main13(string[] args)
        {
            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("last element");

            Console.WriteLine(linkedList.First.Value);
                
            if (linkedList.Contains("last element"))
            {
                Console.WriteLine(linkedList.Last.Value);
            }

            LinkedListNode<string>? node = linkedList.Find("root");
            LinkedListNode<string>? node1 = linkedList.FindLast("root");

            linkedList.Remove(node);
            // linkedList.RemoveFirst();
            // linkedList.RemoveLast();
            linkedList.Clear();
        }
    
    }

    class Example14<T>
    {
        public static void Main14(string[] args)
        {
            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");
            
            //TreeNode<string> d = new TreeNode<string>("d");
            //TreeNode<string> e = new TreeNode<string>("e");
            //TreeNode<string> f = new TreeNode<string>("f");
            //TreeNode<string> g = new TreeNode<string>("g");

            // a.SetLeft(b);//        a
            // a.SetRight(c);//     /   \
            // b.SetLeft(d);//     b     c
            // c.SetLeft(e);//    / \   / \
            // e.SetLeft(f);//   d   e f   g
            // e.SetRight(g);//

            // Console.WriteLine(Program14<string>.GetHeight(a)); // 3

            a.SetLeft(b);
            a.SetRight(c);

            PreOrder(a); // a b c
            InOrder(a); // b a c
            PostOrder(a); // b c a
        }

        static void PreOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                Console.Write(root.GetValue().ToString() + " ");
                PreOrder(root.GetLeft());
                PreOrder(root.GetRight());
            }
        }

        static void InOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                InOrder(root.GetLeft());
                Console.Write(root.GetValue().ToString() + " ");
                InOrder(root.GetRight());
            }
        }

        static void PostOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                PostOrder(root.GetLeft());
                PostOrder(root.GetRight());
                Console.Write(root.GetValue().ToString() + " ");
            }
        }

        static bool IsBalanced(TreeNode<string> root)
        {
            int diff = 0;

            if(root.GetLeft() != null && root.GetRight() == null || root.GetLeft() == null && root.GetRight() != null )
            {
                diff += 1;
            }
            else
            {
                diff = 0;
            }

            return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
        }

    }
    public class Program14<T>
    {
        public static int GetHeight(TreeNode<T> root)
        {
            if (root == null) { return 0; }
            return Math.Max(GetHeight(root.GetLeft()), GetHeight(root.GetRight()) + 1);
        }
    }

    public class TreeNode<T>
    {
        T value;
        TreeNode<T> left = null;
        TreeNode<T> right = null;

        public TreeNode(T value)
        {
            this.value = value;
        }

        public TreeNode<T> GetLeft()
        {
            return left;
        }

        public TreeNode<T> GetRight()
        {
            return right;
        }

        public T GetValue()
        {
            return value;
        }

        public void SteValue(T value)
        {
            this.value = value;
        }

        public void SetLeft(TreeNode<T> node)
        {
            left = node;
        }

        public void SetRight(TreeNode<T> node)
        {
            right = node;
        }
    }

    class Example15a
    {
        public static void Main15a(string[] args)
        {
            NodeA one = new NodeA(1);
            NodeA two = new NodeA(2);
            NodeA three = new NodeA(3);
            NodeA four = new NodeA(4);
            NodeA five = new NodeA(5);
            NodeA six = new NodeA(6);

            GraphA graph = new GraphA(6);

            graph.AddEdge(six, four);
            graph.AddEdge(four, five);
            graph.AddEdge(four, three);
            graph.AddEdge(three, two);
            graph.AddEdge(five, two);
            graph.AddEdge(two, one);
            graph.AddEdge(five, one);
        }
    }

    class NodeA
    {
        public List<object> Neighbours { get; set; }
        public int Data;

        public NodeA (int data)
        {
            Data = data;
        }

        public NodeA ()
        {

        }
    }

    class GraphA
    {
        public int NumberOfVertices { get; set; }
        public List<NodeA> Vertices { get; set; }

        public GraphA (int size)
        {
            NumberOfVertices = size;
            Vertices = new List<NodeA>();

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Vertices[i] = new NodeA();
            }
        }

        public void AddEdge (NodeA source, NodeA destination)
        {
            source.Neighbours.Add(destination);
            destination.Neighbours.Add(source);
        }

        public void RemoveEdge (NodeA source, NodeA destination)
        {
            source.Neighbours.Remove(destination);
            destination.Neighbours.Remove(source);
        }

        public bool IsAdjacent (NodeA node1, NodeA node2)
        {
            return node1.Neighbours.Contains(node2);
        }
    }

    class GraphB
    {
        bool[,] adjacencyMatrix;
        int NumberOfVertices { get; set; }

        public GraphB (int size)
        {
            NumberOfVertices = size;
            adjacencyMatrix = new bool[size, size];
        }

        public void AddEdge (int i, int j)
        {
            adjacencyMatrix[i, j] = true;
            adjacencyMatrix[j, i] = true;
        }

        public void RemoveEdge (int i, int j)
        {
            adjacencyMatrix[i, j] = false;
            adjacencyMatrix[j, i] = false;
        }

        public bool IsAdjacent (int i, int j)
        {
            return adjacencyMatrix[i, j];
        }
    }

}