using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            
        }
        
    }
}