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
                Console.WriteLine("4] >> Check your remaining balance");
                Console.WriteLine("Q] >> Quit");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("How much money are you feeding the vending machine? ");
                    decimal moneyFed = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                    vm.FeedMoney(moneyFed);
                    Console.WriteLine($"Current Total Money Provided: ${vm.Balance}");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Please select which product you would like to purchase by the slot identification: ");
                    string itemSelected = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    vm.SelectProduct(itemSelected);
                    PurchaseMenuCLI submenu = new PurchaseMenuCLI(vm);
                    submenu.Display();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Performing submenu option 3");
                }
                else if (input == "4")
                {
                    Console.WriteLine($"You have ${vm.Balance} left.");
                }
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Returning to main menu");
                    MainMenuCLI mainMenu = new MainMenuCLI(vm);
                    mainMenu.Display();
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
