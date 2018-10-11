using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenuCLI
    {
        private VendingMachine vm;

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

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("How much money are you feeding the vending machine? ");
                    int moneyFed = int.Parse(Console.ReadLine());
                    vm.FeedMoney(moneyFed);
                    Console.WriteLine($"Current Total Money Provided: ${vm.Balance}");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Performing submenu option 2");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Performing submenu option 3");
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

                Console.ReadLine();
            }
        }
    }
}
