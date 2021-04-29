using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    // Abstract Product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
