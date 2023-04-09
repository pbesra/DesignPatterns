using DesignPatterns.BehavioralDesignPatterns;
using DesignPatterns.CreationalDesignPatterns;
using DesignPatterns.StructuralDesignPatterns;  

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var abstractFactory = new AbstractFactory()
                .GenerateFactory(FactoryType.Laptop)
                .CreateDevice(DeviceType.DELL);
            Console.WriteLine(abstractFactory.GetDetails());
        }
    }
}