using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    // delegate is function pointer
    // used in event handling
    // singlecast delegate & multicast delegate

    internal class Program
    {
        public void fun()
        {
            Console.WriteLine("Function Body");
        }

        public void fun1()
        {
            Console.WriteLine("Function Body1");
        }

        public delegate void myDel();

        public static void Main(string[] args)
        {
            Program obj = new Program();
            myDel del = new myDel(obj.fun);
            del += obj.fun1;
            //del -= obj.fun1;  
            del();
        } 
    }


    //public delegate void Notify(string msg);

    //public class Process
    //{
    //    public void StartPR(Notify notify)
    //    {
    //        notify("Send message");
    //    }
    //}

    //public class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        Process pr = new Process();
    //        pr.StartPR((msg) => Console.WriteLine(msg));
    //    }
    //}
}

