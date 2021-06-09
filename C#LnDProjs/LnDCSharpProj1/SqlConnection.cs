using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class SqlConnection : DbConnection
    {
        SqlConnection(string connectionString) 
            : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Opening SQL DB Connection.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL DB Connection.");
        }
    }
}
