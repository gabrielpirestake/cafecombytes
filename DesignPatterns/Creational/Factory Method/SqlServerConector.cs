using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    // Concrete Product
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
