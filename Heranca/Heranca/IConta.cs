using Heranca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    interface IConta
    {
        public void Retirada(double quantia);
        public void Deposito(double quantia);
        public void Emprestimo(double quantia);
        public void Aplicacao();
        
    }
}
