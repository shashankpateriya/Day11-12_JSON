using System;
using System.Collections.Generic;

namespace JSON_Inventory
{
    class Program
    {
        public static List<Inventory> inventories = new List<Inventory>();

        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            var inventories = fileReader.GetInventry();

            foreach (var i in inventories)
            {
                Console.WriteLine("Name : " + i.Name);
                Console.WriteLine("Weight : " + i.Weight);
                Console.WriteLine("Price : " + i.Price);
            }
        }

    }
}