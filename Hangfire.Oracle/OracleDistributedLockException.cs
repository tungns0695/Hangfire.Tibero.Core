using System;

namespace Hangfire.Tibero.Core
{
    public class OracleDistributedLockException : Exception
    {
        public OracleDistributedLockException(string message) : base(message)
        {
        }
    }
}
