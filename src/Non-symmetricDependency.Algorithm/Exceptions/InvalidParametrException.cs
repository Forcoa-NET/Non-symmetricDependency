using System;
using System.Collections.Generic;
using System.Text;

namespace Non_symmetricDependency.Algorithm.Exceptions
{
    public class InvalidParametrException : AlgDomainException
    {
        public InvalidParametrException(string message) : base(message) 
        {
        }
    }
}
