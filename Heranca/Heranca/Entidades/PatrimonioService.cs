using Heranca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    public sealed class PatrimonioService : IPatrimonioService
    {
        public void SomaPatrimonio(List<IConta> contas)
        {
            var patrimonio = 0m;

            foreach (IConta conta in contas)
            {
                patrimonio += conta.Saldo();
            }

            Console.WriteLine($"O seu patrimonio total é de {patrimonio:N2}");
        }
    }
}
