using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Adaptee
    public class ExternalAccount : IExternalAccount
    {
        public void Deposit(decimal value)
        {
            Console.WriteLine($"Deposit of: {value.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");
        }

        public void Withdraw(decimal value)
        {
            Console.WriteLine($"Withdraw of: {value.ToString("C2", CultureInfo.GetCultureInfo("en-US"))}");
        }
    }
}
