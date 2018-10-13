using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item
    {
        /// <summary>
        /// Cost of the item
        /// </summary>
        public decimal Cost {get; set;}

        /// <summary>
        /// Slot where item is stored
        /// </summary>
        public string SlotID { get; set; }

        /// <summary>
        /// Name of item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Number of items left in stock
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Type of item (Drink, Chips, Candy, or Gum)
        /// </summary>
        public string Type { get; set; }

        public Item(string slotId, string name, decimal cost, string type)
        {
            this.SlotID = slotId;
            this.Name = name;
            this.Cost = cost;
            this.Type = type;
            this.Quantity = 5;
        }

        public string MakeSound()
        {
            string sound = "";

            if (this.Type == "Chip")
            {
                sound = "Crunch Crunch, Yum!";
            }
            else if (this.Type == "Candy")
            {
                sound = "Munch Munch, Yum!";
            }
            else if (this.Type == "Drink")
            {
                sound = "Glug Glug, Yum!";
            }
            else
            {
                sound = "Chew Chew, Yum!";
            }
            return sound;
        }
    }
}
