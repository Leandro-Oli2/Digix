using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex08._01_Excecoes
{
    public class DomainExcept : ApplicationException
    {
        public DomainExcept(string message) : base(message)
        {
        }
        
    }
}