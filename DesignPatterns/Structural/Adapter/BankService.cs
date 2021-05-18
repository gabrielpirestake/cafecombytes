using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Client
    public class BankService
    {
        private readonly IAccount _account;
        public BankService(IAccount account)
        {
            _account = account;
        }

        public void Withdraw()
        {
            _account.Withdraw(100.40m);
        }

        public void Deposit()
        {
            _account.Deposit(100.40m);
        }
    }
}
