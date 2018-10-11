﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        /// <summary>
        /// Current balance of the vending machine
        /// </summary>
        public int Balance { get; set; }

        public VendingMachine()
        {
            this.Balance = 0;
        }


        //}
        /// <summary>
        /// A customer puts in their money and balance is updated
        /// </summary>
        /// <param name="money"></param>
        public int FeedMoney(int moneyFed)
        {
            if(moneyFed > 0)
            {
                this.Balance += moneyFed;
            }
            return Balance;
        }
        
    }
}