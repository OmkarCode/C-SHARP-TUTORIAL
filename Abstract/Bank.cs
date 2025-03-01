using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Bank
    {
        internal int balance = 15000;
        abstract public void Credit(int amt);
        abstract public void Debit(int amt);
        abstract public bool Login(int pass);
        abstract public void CheckBalance();

        void BankInfo() {
            Console.WriteLine("HDFC BANK");
        }
    }
}
