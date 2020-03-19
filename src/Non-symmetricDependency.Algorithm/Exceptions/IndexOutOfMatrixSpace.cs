using System;
using System.Collections.Generic;
using System.Text;

namespace Non_symmetricDependency.Algorithm.Exceptions
{
    public class IndexOutOfMatrixSpace : AlgDomainException
    {
        public IndexOutOfMatrixSpace(string message) : base(message) 
        {
        }
    }
}
