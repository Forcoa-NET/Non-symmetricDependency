using System;

namespace Non_symmetricDependency.Algorithm.Exceptions
{
    public class AlgDomainException : Exception
    {
        public AlgDomainException(string message) : base(message)
        {
        }
    }
}
