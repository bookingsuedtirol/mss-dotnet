using System;

namespace MssNet
{
    public class MssException : Exception
    {
        public MssException(string message) : base(message)
        {
        }
    }
}
