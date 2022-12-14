using Heranca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    interface IAccount
    {
        public void Withdraw(double quantia);
        public void Deposit(double quantia);
        public void Loan(double quantia);
        public void UpdateBalance();
        
    }
}
