using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class VMLogger
    {
        public void LogFeed(decimal amountFed, decimal finalAmount)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy Hh:mm:ss tt"));
                sw.Write(" FEED MONEY: ");
                sw.Write($"${amountFed} ");
                sw.Write($"${finalAmount}");
                sw.WriteLine();
            }
        }

        public void LogPurchase(Item item, decimal initialBalance, decimal finalBalance)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy Hh:mm:ss tt"));
                sw.Write($"{item.Name} {item.SlotID} ");
                sw.Write($"${initialBalance} ");
                sw.Write($"${finalBalance}");
                sw.WriteLine();
            }
        }

        public void LogChange(decimal change, decimal balance)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.Write(DateTime.Now.ToString("MM/dd/yyyy Hh:mm:ss tt"));
                sw.Write(" GIVE CHANGE: ");
                sw.Write($"${change} ");
                sw.Write($"${balance}");
                sw.WriteLine();
            }
        }
    }
}
