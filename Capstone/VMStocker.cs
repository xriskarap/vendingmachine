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


                    // turn into item


                    // add item to list 
                }
            }
            return itemInventory;
        }
    }
}
