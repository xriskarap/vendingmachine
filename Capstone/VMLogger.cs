using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class VMLogger
    {
        private const string LogFile = "Log.txt";

        /// <summary>
        /// Logs money fed to vending machine to Log.txt file
        /// </summary>
        /// <param name="amountFed">Amount Fed to Vending Machine</param>
        /// <param name="finalAmount">Updated total amount fed to vending machine</param>
        public void LogFeed(decimal amountFed, decimal finalAmount)
        {
            this.LogMessage($"FEED MONEY: {amountFed:C} {finalAmount:C}");
        }

        /// <summary>
        /// Logs customer purchases
        /// </summary>
        /// <param name="item">Item purchased</param>
        /// <param name="initialBalance">Balance available to purchase items</param>
        /// <param name="finalBalance">Updated balance after purchase</param>
        public void LogPurchase(Item item, decimal initialBalance, decimal finalBalance)
        {
            this.LogMessage($"{item.Name} {item.SlotID}: {initialBalance:C} {finalBalance:C}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="change"></param>
        /// <param name="balance"></param>
        public void LogChange(decimal change, decimal balance)
        {
            this.LogMessage($"GIVE CHANGE: {change:C} {balance:C}");
        }

        private void LogMessage(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(LogFile, true))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("MM/dd/yyyy :HH:mm:ss tt")} {message}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing log file.");
            }
        }
    }
}
