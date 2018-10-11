using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class MainMenuCLI
    {
        private VendingMachine vm;

        public MainMenuCLI(VendingMachine vm)
        {
            this.vm = vm;
        }

        public void Display()
        {
            while (true)
            {
                PrintHeader();

                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] >> Display Vending Machine Items");
                Console.WriteLine("2] >> Purchase Item");
                Console.WriteLine("Q] >> Quit");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                   
                    foreach (Item item in vm.Items)
                    {
                        Console.WriteLine($"{item.Name}");
                    }
                }
                else if (input == "2")
                {
                    PurchaseMenuCLI submenu = new PurchaseMenuCLI(vm);
                    submenu.Display();
                }
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine("WELCOME TO OUR AWESOME VENDING MACHINE!!!");
        }
    }
}
