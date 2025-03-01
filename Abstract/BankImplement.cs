using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class BankImplement : Bank
    {
        public override void CheckBalance()
        {
            if (Login(1234))
            {
                Console.WriteLine("Balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Pass Code");
            }
        }

        public override void Credit(int amt)
        {
            if (Login(1234))
            {
                balance += amt;
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Pass Code");
            }
        }

        public override void Debit(int amt)
        {
            if (Login(1234))
            {
                balance -= amt;
                CheckBalance();
            }
            else {
                Console.WriteLine("Invalid Pass Code");
            }
        }
        public override bool Login(int pass)
        {
            if(pass == 1234)
            {
                 return true;
            }
            else
            {
                 return false;
            }
        }
    }
}
