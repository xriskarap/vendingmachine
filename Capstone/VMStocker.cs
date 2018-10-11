using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class VMStocker
    {
        public List<Item> GetStock()
        {
            List<Item> itemInventory = new List<Item>();
            using (StreamReader sr = new StreamReader("ItemInventory.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // break by delimeter
                    // creating an array containing the properties of an Item
                    string[] itemInfo = line.Split('|');
                    string slotID = itemInfo[0];
                    string name = itemInfo[1];
                    decimal cost = decimal.Parse(itemInfo[2]);
                    string type = itemInfo[3];
                    
                    // setting the properties to a new Item
                    Item item = new Item(slotID, name, cost, type);

                    // add item to list 
                    itemInventory.Add(item);
                }
            }
            return itemInventory;
        }
    }
}
