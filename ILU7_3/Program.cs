using System;
using System.Collections.Generic;
namespace ILU7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> area = new Dictionary<string, int>();
            area.Add("Sverige", 450);
            area.Add("Norge", 385);
            area.Add("Danmark", 43);
            area.Add("Finland", 338);
            Console.WriteLine("Skriv in antingen Sverige, Norge, Danmark eller finland för att få reda på dess area");
            string land=Console.ReadLine();
            
            foreach(KeyValuePair<string, int> kvp in area) 
            {
                if (land == kvp.Key)
                {
                    Console.WriteLine(kvp.Value+"*10^5km^2");
                }
            }
            


        }
    }

}