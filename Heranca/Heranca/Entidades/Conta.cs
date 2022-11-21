using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidades
{
    
    //Private = somente a propria classe pode acessa-la ou atualiza-lá
    //Protect = somente a propria classe 
    class Conta : IConta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        
        public virtual void Retirada(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public virtual void Emprestimo(double quantia)
        {
            throw new NotImplementedException();
        }

        public virtual void atualizarSaldo()
        {
            throw new NotImplementedException();
        }


    }
}
