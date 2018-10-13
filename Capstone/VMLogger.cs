using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class VMLogger
    {
        /// <summary>
        /// Logs money fed to vending machine to Log.txt file
        /// </summary>
        /// <param name="amountFed">Amount Fed to Vending Machine</param>
        /// <param name="finalAmount">Updated total amount fed to vending machine</param>
        public void LogFeed(decimal amountFed, decimal finalAmount)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                sw.Write(" FEED MONEY: ");
                sw.Write($"{amountFed:C} ");
                sw.Write($"{finalAmount:C}");
                sw.WriteLine();
            }
        }

        /// <summary>
        /// Logs customer purchases
        /// </summary>
        /// <param name="item">Item purchased</param>
        /// <param name="initialBalance">Balance available to purchase items</param>
        /// <param name="finalBalance">Updated balance after purchase</param>
        public void LogPurchase(Item item, decimal initialBalance, decimal finalBalance)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                sw.Write($" {item.Name} {item.SlotID}: ");
                sw.Write($"{initialBalance:C} ");
                sw.Write($"{finalBalance:C}");
                sw.WriteLine();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="change"></param>
        /// <param name="balance"></param>
        public void LogChange(decimal change, decimal balance)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                sw.Write(" GIVE CHANGE: ");
                sw.Write($"{change:C} ");
                sw.Write($"{balance:C}");
                sw.WriteLine();
            }
        }
    }
}
