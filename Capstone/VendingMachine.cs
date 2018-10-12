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

        public Item SelectProduct(string slot)
        {
            Item selectedItem = null;
            foreach (Item item in Items)
            {
                if (item.SlotID == slot)
                {
                    selectedItem = item;
                    break;
                }
            }
            if (selectedItem == null)
            {  
                // Tell customer the selected item does not exist
                Console.WriteLine($"Sorry, {slot} is not a valid slot choice. Please make another selection.");
                // return to purchase menu
            }
            //if the selected item exists, AND there are at least 1 left in stock,
            // AND the balance is LESS than item cost
            else if (selectedItem.Quantity > 0 && Balance < selectedItem.Cost)
            {

                Console.WriteLine("Sorry, you have insufficient funds, please add more money to make that selection.");
            }
            //if the selected item exists, AND there are at least 1 in stock, 
            //AND the balance is greater than the item cost
            else if (selectedItem.Quantity > 0 && Balance > selectedItem.Cost)
            {
                //dispense to customers
                Console.WriteLine($"Thank you for your purchase. Here is your {selectedItem.Name}!");
                // update balance
                this.Balance -= selectedItem.Cost;
                // update quantity
                selectedItem.Quantity -= 1;
                //return to purchase menu
            }
            //If the item selected exists in the machine, but has no quantity left
            else if (selectedItem.Quantity == 0)
            {
                //tell customer the selected item is sold out
                Console.WriteLine($"Sorry, {selectedItem.Name} is sold out. Please make another selection.");
                //return to purchase menu
            }

            return selectedItem;
        }

    }
}
