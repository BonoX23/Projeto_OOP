using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Services
{
    public interface IConta
    {
        void MostraSaldo();
        decimal Saldo();
    }
}
