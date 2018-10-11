using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class MainMenuCLI
    {
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
                    VMStocker stock = new VMStocker();
                    List<string> itemList = stock.GetStock();
                    foreach (string item in itemList)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                else if (input == "2")
                {
                    PurchaseMenuCLI submenu = new PurchaseMenuCLI();
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
