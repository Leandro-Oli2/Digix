using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor); // Isso é implicitamente publico
        void ExibirComprovante();
    }
}