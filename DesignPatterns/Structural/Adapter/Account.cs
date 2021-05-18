using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Target 
    public class Account : IAccount
    {
        public void Deposit(decimal value)
        {
            Console.WriteLine($"Depósito de: {value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
        }

        public void Withdraw(decimal value)
        {
            Console.WriteLine($"Saque de: {value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
        }
    }
}
