using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public sealed class Singleton
    {
        // Custom delegate
        delegate Singleton SingletonDelegateWithNoParameter();

        static SingletonDelegateWithNoParameter myDel = MakeSingletonInstance;

        // Using built-in Func<out TResult> delegate 
        static Func<Singleton> myFuncDelegate = MakeSingletonInstance;

        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(
            //myDel() // Also ok. Using a custom delegate 
            myFuncDelegate()
            //() => new Singleton() // Using lambda expression 
            );

        private static Singleton MakeSingletonInstance() { return new Singleton(); }
        private Singleton() { }
        public static Singleton GetInstance { get { return Instance.Value; } }

        public void SaySomething()
        {
            Console.Write("Something!");
        }

    }
}
