using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    // Concrete Creator
    public class SqlFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
