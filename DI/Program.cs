using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    //Without DI:
    //public class Parent
    //{
    //    public void DoWork() => Console.WriteLine("Parent is working.");
    //}

    //public class Child
    //{
    //    private Parent _parent;

    //    public Child()
    //    {
    //        _parent = new Parent(); // Child creates its dependency
    //    }

    //    public void StartWork()
    //    {
    //        _parent.DoWork();
    //    }
    //}


    //With DI:
    //public interface IParent
    //{
    //    void DoWork();
    //}

    //public class Parent : IParent
    //{
    //    public void DoWork() => Console.WriteLine("Parent is working.");
    //}

    //public class Child
    //{
    //    private readonly IParent _parent;

    //    public Child(IParent parent) // Dependency is injected here
    //    {
    //        _parent = parent;
    //    }

    //    public void StartWork()
    //    {
    //        _parent.DoWork();
    //    }

    //    static void Main(string[] args) { 
    //        //Parent p = new Parent();
    //        Child c = new Child( new Parent()); 

    //        //c.DoWork();
    //    }
    //}

    namespace DI
    {
        // Interface for Parent class
        public interface IParent
        {
            void DoWork();
        }

        // Implementation of the Parent class
        public class Parent : IParent
        {
            public void DoWork() => Console.WriteLine("Parent is working.");
        }

        // Child class that accepts dependency through DI
        public class Child
        {
            private readonly IParent _parent;

            // Constructor injection of dependency
            public Child(IParent parent)
            {
                _parent = parent;
            }

            public void StartWork()
            {
                _parent.DoWork();  // Delegate work to the Parent class
            }

            static void Main(string[] args)
            {
                // Inject Parent class instance into Child
                Child c = new Child(new Parent());

                // Start work using the Parent class functionality through Child
                c.StartWork();
            }
        }
    }



}
