using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        public delegate String demoDelegate(String s1, String s2);
        event demoDelegate myEvent;

        Program()
        {
            this.myEvent += Program_myEvent;
        }

        private string Program_myEvent(string s1, string s2)
        {
            return "Hello" + s1 + s2;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.myEvent("hello1", "hello2"));
        }
    }
}
