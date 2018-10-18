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
            const int PosSlotId = 0;
            const int PosName = 1;
            const int PosCost = 2;
            const int PosType = 3;

            List<Item> itemInventory = new List<Item>();
            using (StreamReader sr = new StreamReader("ItemInventory.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // break by delimeter
                    // creating an array containing the properties of an Item
                    string[] itemInfo = line.Split('|');
                    string slotID = itemInfo[PosSlotId];
                    string name = itemInfo[PosName];
                    decimal cost = decimal.Parse(itemInfo[PosCost]);
                    string type = itemInfo[PosType];

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
