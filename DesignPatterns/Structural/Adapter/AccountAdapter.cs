using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Adapter
    public class AccountAdapter : IAccount
    {
        private readonly IExternalAccount _externalAccount;
        public AccountAdapter(IExternalAccount externalAccount)
        {
            _externalAccount = externalAccount;
        }

        public void Deposit(decimal value)
        {
            _externalAccount.Deposit(value);
        }

        public void Withdraw(decimal value)
        {
            _externalAccount.Withdraw(value);
        }
    }
}
