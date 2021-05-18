using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface IAccount
    {
        void Withdraw(decimal value);
        void Deposit(decimal value);
    }
}
