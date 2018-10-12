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
                //if the selected item exists, AND there are at least 1 left in stock,
                // AND the balance is LESS than item cost
                if (item.SlotID == itemSelected && item.Quantity > 0 && Balance < item.Cost)
                {
                    Console.WriteLine("Sorry, you have insufficient funds, please add more money to make that selection.");
                }
                //if the selected item exists, AND there are at least 1 in stock, 
                //AND the balance is greater than the item cost
                else if (item.SlotID == itemSelected && item.Quantity > 0 && Balance > item.Cost)
                {
                    //dispense to customers
                    Console.WriteLine($"Thank you for your purchase. Here is your {itemSelected}!");
                    // update balance
                    this.Balance -= item.Cost;
                    // update quantity
                    item.Quantity -= 1;
                }
                //If the item selected exists in the machine, but has no quantity left
                else if (item.SlotID == itemSelected && item.Quantity == 0)
                {
                    //tell customer the selected item is sold out
                    Console.WriteLine($"Sorry, {itemSelected} is sold out. Please make another selection.");
                }
                else
                {
                    // Tell customer the selected item does not exist
                    Console.WriteLine($"Sorry, {itemSelected} is not a valid item. Please make another selection.");
                }
            }
            return null;
        }

    }
}
