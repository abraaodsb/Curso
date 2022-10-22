using System;
using System.Collections.Generic;
using System.Text;
using Curso.Entities.Exceptions;

namespace Curso.Entities.Exceptions
{
    class DomainException : ApplicationException 
    {
        public DomainException(string Message) : base(Message)
        {

        }
    }
}
