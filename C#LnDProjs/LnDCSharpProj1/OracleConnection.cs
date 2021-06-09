using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class OracleConnection : DbConnection
    {
        OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Opening Oracle DB Connection.");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle DB Connection.");
        }
    }
}
