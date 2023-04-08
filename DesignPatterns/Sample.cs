using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Sample
    {
        public static void PrintResult(char delimiter=',')
        {
            string names = $@"


hello world, 
what about this, admission officer, supply teacher,
wfbiwbf,
wkjfrnorjg,
ornorng3org jfn3ir,3fn3irbg3igb 3rb3igb3 3rb3igb3igb 3ri3ig, 3rb3irgb3g, 3irbg3ibg3, 3irfb3ibg 3rb3ibg      
, 3irb3igb3,




";
            var nameList = names.Split(delimiter);
            var nameSet = new List<string>();
            foreach (var name in nameList)
            {
                var x = name.Trim();
                if (x.Length > 0)
                {
                    nameSet.Add($"({x})");
                }
            }
            string actualName = string.Join(",", nameSet);
            Console.WriteLine(actualName);
        }
    }
}
