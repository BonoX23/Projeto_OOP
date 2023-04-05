using Heranca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    public abstract class ContaBase
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public decimal Balance { get; set; }

        protected ContaBase(string holder, int number)
        {
            Holder = holder;
            Number = number;
            Balance = 0;
        }

        public abstract void Retirada(decimal amount);
        public abstract void Deposito(decimal amount);

        public static decimal SomaSaldoContas(IEnumerable<ContaBase> contas)
        {
            decimal saldoTotal = 0;

            foreach (var conta in contas)
            {
                saldoTotal += conta.Balance;
            }

            return saldoTotal;
        }

    }

    public class ContaPoupanca : ContaBase , IConta
    {
        public decimal Taxa { get; set; }

        public ContaPoupanca(string holder, int number, decimal taxa) : base(holder, number)
        {
            Taxa = taxa;
        }

        public override void Deposito(decimal amount)
            => Balance += (Balance + amount) * Taxa + amount;



        public override void Retirada(decimal amount)
        {
            Balance -= amount + 2.0m;
        }

        public void MostraSaldo()
        {
            Console.WriteLine($"O saldo dessa conta poupança é {Balance}");
        }

        public decimal Saldo()
        {
            return Balance;
        }
    }

    public class ContaEmpresarial : ContaBase, IConta
    {
        public decimal Loan { get; set; }
        public ContaEmpresarial(string holder, int number, decimal loan) : base(holder, number)
        {
            Loan = loan;
        }

        public override void Deposito(decimal amount)
        {
            Balance += Balance + amount;
        }

        public override void Retirada(decimal amount)
        {
            Balance -= amount + 3.0m;
        }

        public void Emprestimo(decimal amount)
        {
            if (Balance <= Loan)
            {
                Balance += amount;
            }
        }

        public void MostraSaldo()
        {
            Console.WriteLine($"O Saldo dessa conta empresarial é {Balance}");
        }

        public decimal Saldo()
        {
            return Balance;
        }
    }
}
