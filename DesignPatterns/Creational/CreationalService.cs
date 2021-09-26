using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Creational.AbstractFactory;
using static DesignPatterns.Creational.ConcreteBuilder;

namespace DesignPatterns.Creational
{
    public static class CreationalService
    {

        internal static void TestSingleton()
        {
            Singleton singleton = Singleton.GetInstance;

            singleton.SaySomething();

            Console.ReadLine();
        }

        internal static void TestPrototype()
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

        internal static void TestBuilder()
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }

        internal static void TestFactory()
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview(); // Output: Asking about design patterns

            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview(); // Output: Asking about community building.
        }

        internal static void TestAbstractFactory()
        {
            var woodenFactory = new WoodenDoorFactory();

            var door = woodenFactory.MakeDoor();
            var expert = woodenFactory.MakeFittingExpert();

            door.GetDescription();  // Output: I am a wooden door
            expert.GetDescription(); // Output: I can only fit wooden doors

            // Same for Iron Factory
            var ironFactory = new IronDoorFactory();

            var door2 = ironFactory.MakeDoor();
            var expert2 = ironFactory.MakeFittingExpert();

            door2.GetDescription();  // Output: I am an iron door
            expert2.GetDescription(); // Output: I can only fit iron doors
        }
    }
}
