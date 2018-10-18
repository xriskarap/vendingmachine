using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenuCLI
    {
        private VendingMachine vm;
        static List<Item> purchasedItems = new List<Item>();
        public PurchaseMenuCLI(VendingMachine vm)
        {
            this.vm = vm;
        }

        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Purchase Menu");
                Console.WriteLine("1] >> Feed Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine("Q] >> Quit");
                Console.WriteLine($"You have ${vm.Balance} left.");
                Console.WriteLine();

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    try
                    {
                        Console.Write("How much money are you feeding the vending machine? ");
                        decimal moneyFed = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        vm.FeedMoney(moneyFed);
                        Console.WriteLine($"Current Total Money Provided: ${vm.Balance}");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("That is not money. Please enter money.");
                    }
                }
                else if (input == "2")
                {
                    Console.Write("Please select which product you would like to purchase by the slot identification: ");
                    string slot = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    Item item = vm.SelectProduct(slot);
                    purchasedItems.Add(item);

                }
                else if (input == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(vm.DispenseChange());

                    // checking the type of the user's item, and returning the sound.
                    foreach (Item item in purchasedItems)
                    {
                        Console.WriteLine(item.MakeSound());
                    }
                }
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
                

            }
        }
    }
}
