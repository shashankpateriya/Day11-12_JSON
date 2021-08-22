using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace JSON_Inventory
{
    public class FileReader
    {
        public List<Inventory> inventories = new List<Inventory>();
        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText(@"C:\Users\hp\source\repos\JSON_Inventory\JSON_Inventory\data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }

    }
}