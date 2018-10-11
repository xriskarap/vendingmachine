using System;
using System.Collections.Generic;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VMStocker stocker = new VMStocker();
            List<Item> items = stocker.GetStock();
            VendingMachine vm = new VendingMachine(items);
            MainMenuCLI mainMenu = new MainMenuCLI(vm);
            mainMenu.Display();
        }
    }
}
