using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Customer
    {
        public static void Main(string[] args)
        {
            Bank obj = new BankImplement();
            obj.Debit(2000);
            obj.Credit(12000);

        }
    }
}
