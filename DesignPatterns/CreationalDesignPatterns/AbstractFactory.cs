
/*
var abstractFactory = new AbstractFactory()
            .GenerateFactory(FactoryType.Laptop)
            .CreateDevice(DeviceType.DELL);
        Console.WriteLine(abstractFactory.GetDetails());
 */

namespace DesignPatterns.CreationalDesignPatterns
{
    public class AbstractFactory
    {
        public IDeviceFactory GenerateFactory(FactoryType deviceType)
        {
            switch (deviceType)
            {
                case FactoryType.Laptop:
                    return new LaptopFactory();
                case FactoryType.Mobile:
                    return new LaptopFactory();
                default:
                    return null;
            }
        }
    }
    public interface IDevice
    {
        string GetDetails();
    }
    public class Dell : IDevice
    {
        public string GetDetails()
        {
            return "Dell Laptop";
        }
    }
    public class Apple : IDevice
    {
        public string GetDetails()
        {
            return "Apple Mobile";
        }
    }
    public class Nokia : IDevice
    {
        public string GetDetails()
        {
            return "Apple Mobile";
        }
    }
    public class Samsung : IDevice
    {
        public string GetDetails()
        {
            return "Apple Mobile";
        }
    }
    public class LaptopFactory : IDeviceFactory
    {
        public IDevice CreateDevice(DeviceType deviceType)
        {
            switch(deviceType)
            {
                case DeviceType.DELL:
                    return new Dell();
                case DeviceType.SAMSUNG: 
                    return new Samsung();
                default:
                    return null;
            }
        }
    }
    public class MobileFactory : IDeviceFactory
    {
        public IDevice CreateDevice(DeviceType deviceType)
        {
            switch(deviceType)
            {
                case DeviceType.NOKIA:
                    return new Nokia();
                case DeviceType.SAMSUNG: 
                    return new Samsung();
                default:
                    return null;
            }
        }
    }
    public interface IDeviceFactory
    {
        IDevice CreateDevice(DeviceType deviceType);
    }
    public  enum FactoryType
    {
        Laptop,
        Mobile
    }
    public enum DeviceType
    {
        DELL,
        APPLE,
        NOKIA,
        SAMSUNG
    }


}