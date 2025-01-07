using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public interface Igerente
    {
        public void Autorizar();
        public bool ConcederAumento();
        public bool AutorizarLicenca(Empregado empregado);
    }
}