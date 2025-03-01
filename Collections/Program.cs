using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NON-GENERIC

            Console.WriteLine("\n\t\t     NON - GENERIC\n");

            Console.WriteLine("*****************    ArrayList    ****************");

            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("HI");
            obj.Add(true);
            obj.Add(54.54);

            foreach (object i in obj)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************   HashTable    ****************");

            Hashtable ht = new Hashtable();
            ht.Add("add1", 1);
            ht.Add("add2", "HI");
            ht.Add("add3", true);
            ht.Add("add4", 54.54);

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }

            Console.WriteLine("*****************   SortedList    ****************");

            SortedList sl = new SortedList();
            sl.Add("add1", 1);
            sl.Add("add3", "HI");
            sl.Add("add2", true);
            sl.Add("add4", 54.54);

            foreach (DictionaryEntry entry in sl)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }

            Console.WriteLine("*****************   Stack    ****************");

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****************   Queue    ****************");

            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }

            // GENERIC

            Console.WriteLine("\n\t\t    GENERIC\n");

            Console.WriteLine("*****************   HashSet<>   ****************");

            HashSet<string> hst = new HashSet<string>();
            hst.Add("a");
            hst.Add("b");
            hst.Add("c");
            hst.Add("b");
            hst.Add("b");
            hst.Add("d");
            hst.Add("e");
            hst.Remove("a");
            foreach (var item in hst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****************   Stack<>    ****************");

            Stack<int> stack = new Stack<int>();
           stack.Push(1);
           stack.Push(2);
           stack.Push(3);
           stack.Push(4);
           stack.Push(5);
           while(stack.Count > 0)
           {
               Console.WriteLine(stack.Pop());
           }

           Console.WriteLine("*****************   Queue<>    ****************");

           Queue<int> q = new Queue<int>();
           q.Enqueue(1);
           q.Enqueue(2);
           q.Enqueue(3);
           q.Enqueue(4);
           q.Enqueue(5);
           while (q.Count > 0)
           {
               Console.WriteLine(q.Dequeue());
           }

            Console.WriteLine("*****************   Dictionary<>    ****************");

            //  SortedList<String,Int32> obj1 = new SortedList<String,Int32>();
            Dictionary<String, Int32> obj1 = new Dictionary<String, Int32>();
            obj1.Add("A", 101);
            obj1.Add("D", 455);
            obj1.Add("B", 201);
            obj1.Add("C", 301);
            foreach (KeyValuePair<String, Int32> o in obj1)
            {
                Console.WriteLine(o.Key + " " + o.Value);
            }

            Console.WriteLine("*****************   List<>    ****************");

            List<Int32> list = new List<Int32>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Remove(3);
            foreach (int o in list)
            {
                Console.WriteLine(o);
            }
        }
    }
}
