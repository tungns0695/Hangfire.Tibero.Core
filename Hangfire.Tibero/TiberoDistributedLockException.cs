using System;

namespace Hangfire.Tibero.Core
{
    public class TiberoDistributedLockException : Exception
    {
        public TiberoDistributedLockException(string message) : base(message)
        {
        }
    }
}
