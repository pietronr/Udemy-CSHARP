using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
