using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Services
{
    public interface IContaService
    {
        void Saldos(params IConta[] contas);
    }
}
