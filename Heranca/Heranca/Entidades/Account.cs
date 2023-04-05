using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Services;

namespace Heranca.Entidades
{

    //Private = somente a propria classe pode acessa-la ou atualiza-lá
    //Protect = somente a propria classe 
    class Account : IServices
    {
        public int Number { get; set; }
        internal string Holder { get; set; }
        internal double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        public virtual string CurrentValue()
        {
            return "Numero da Conta: "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo atual: R$"
                + Balance.ToString("F2");
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Loan(double amount)
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateBalance()
        {
            throw new NotImplementedException();
        }


    }
}
