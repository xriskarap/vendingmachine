using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class VMStocker
    {
        public List<string> GetStock()
        {
            List<string> itemInventory = new List<string>();

            using (StreamReader sr = new StreamReader("ItemInventory.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    itemInventory.Add(line);
                }
            }
            return itemInventory;
        }
    }
}
