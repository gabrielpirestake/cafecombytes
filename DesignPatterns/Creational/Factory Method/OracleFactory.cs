using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    // Concrete Creator
    public class OracleFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}
