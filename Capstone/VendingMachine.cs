using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public List<Item> Items { get; }

        /// <summary>
        /// Current balance of the vending machine
        /// </summary>
        public decimal Balance { get; set; }


        public VendingMachine(List<Item> items)
        {
            this.Items = items;
            this.Balance = 0;
        }

        /// <summary>
        /// A customer puts in their money and balance is updated
        /// </summary>
        /// <param name="money"></param>
        public decimal FeedMoney(decimal moneyFed)
        {
            if (moneyFed > 0)
            {
                this.Balance += moneyFed;
            }
            return Balance;
        }

        public Item SelectProduct(string itemSelected)
        {
            foreach (Item item in Items)
            {
                if (item.SlotID == itemSelected && item.Quantity > 0 && Balance > item.Cost)
                {
                    //dispense to customers
                    Console.WriteLine($"Thank you for your purchase. Here is your {itemSelected}!");
                    // update balance
                    this.Balance -= item.Cost;
                    // update quantity
                    item.Quantity -= 1;
                    //return to purchase menu
                    break;
                }
                else if (item.SlotID == itemSelected && item.Quantity == 0)
                {
                    //tell customer it is sold out
                    Console.WriteLine($"Sorry, {itemSelected} is sold out. Please make another selection.");
                    //return to purchase menu
                    break;
                }
                else
                {
                    // Tell customer it does not exist
                    Console.WriteLine($"Sorry, {itemSelected} is not a valid item. Please make another selection.");
                    // return to purchase menu
                    break;
                }
            }
            return null;
        }

    }
}
