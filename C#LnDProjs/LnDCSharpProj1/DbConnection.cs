using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    public abstract class DbConnection
    {

        private string _connectionString;
        private TimeSpan _timeoutException;

        public string ConnectionString
        {
            get 
            {
                if (String.IsNullOrEmpty(_connectionString))
                {
                    throw new InvalidOperationException("Connection string is null or not set. Please set to valid value.");
                }
                else
                {
                    return _connectionString;
                }                 
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidOperationException("Connection String cannot be null.");
                }
                else
                {
                    _connectionString = value;
                }
            }
        }

        public TimeSpan TimeOutTime
        {
            get
            {
                if (_timeoutException != null)
                {
                    if (!String.IsNullOrEmpty(_timeoutException.ToString()))
                    {
                        return _timeoutException;
                    }
                    else
                    {
                        throw new InvalidOperationException("string Timeout time is null or empty. ");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Timeout time is null. ");
                }
            }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new InvalidOperationException("Timeout Input must not be null or empty. ");
                } 
                else
                {
                    _timeoutException = value;
                }
            }
        }

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
