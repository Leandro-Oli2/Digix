using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public interface IAnimalDeEstimação
    {
        void SetNome(string nome);
        string GetNome();
        void Brincar();
    }
}