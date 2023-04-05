using Heranca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    public sealed class ContaService : IContaService
    {
        public void Saldos(params IConta[] contas)
        {
            foreach (IConta conta in contas)
            {
                conta.MostraSaldo();
            }
        }
    }
}
