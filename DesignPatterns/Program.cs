using DesignPatterns.Creational;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton();
            TestPrototype();
        }


        private static void TestSingleton()
        {
            Singleton singleton = Singleton.GetInstance;

            singleton.SaySomething();

            Console.ReadLine();
        }

        private static void TestPrototype()
        {
            var original = new Zed(new System.Numerics.Vector3(10, 10, 10), "GUID-1", "PlayerName");
            Console.WriteLine(original.Position);
            Console.WriteLine(original.Id);
            Console.WriteLine(original.PlayerName);

            Zed clone = (Zed)original.Clone();
            clone.Position = new System.Numerics.Vector3(20, 20, 20);
            clone.Id = "GUID-2";
            Console.WriteLine(clone.Position);
            Console.WriteLine(clone.Id);
            Console.WriteLine(clone.PlayerName);

            Console.ReadLine();
        }
    }
}
