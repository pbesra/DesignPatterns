/*var factoryMethod = new FactoryMethod();
var pc = factoryMethod.GetComputer("pc", "16gb", "256gb", "1TB").ToString();
var server = factoryMethod.GetComputer("server", "64gb", "500gb", "1TB").ToString();
Console.WriteLine(pc, server);
Console.WriteLine(server);*/

namespace DesignPatterns.CreationalDesignPatterns
{
    public class FactoryMethod
    {
        public IComputer GetComputer(string name, string ram, string ssd, string hdd)
        {
            switch (name)
            {
                case "pc":
                    return new PC { SSD=ssd, RAM=ram, HDD=hdd };

                case "server":
                    return new Server{ SSD = ssd, RAM = ram, HDD = hdd };

                default:
                    return null;
            }
        }
    }

    public interface IComputer
    {
        string ToString();

        double GetCost();
        string GetVendor();
    }

    public class PC : IComputer
    {
        public string RAM { get; set; }
        public string SSD { get; set; }
        public string HDD { get; set; }

        public string ToString()
        {
            return $"Here is your pc , ram={RAM}, ssd={SSD}, hdd={HDD}, cost={GetCost()}, vendor={GetVendor()}";
        }

        public double GetCost()
        {
            return 1000;
        }
        public string GetVendor()
        {
            return "pc xyz";
        }
    }

    public class Server : IComputer
    {
        public string RAM { get; set; }
        public string SSD { get; set; }
        public string HDD { get; set; }

        public string ToString()
        {
            return $"Here is your Server , ram={RAM}, ssd={SSD}, hdd={HDD}, cost={GetCost()}, vendor={GetVendor()}";
        }

        public double GetCost()
        {
            return 5000;
        }
        public string GetVendor()
        {
            return "server line";
        }
    }
}