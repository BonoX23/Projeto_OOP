using Heranca.Entidades;
using System;

namespace Heranca.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1001, "Alex", 500.00);

            Conta c2 = new ContaPoupanca(1002, "Ana", 500.00, 0.02);

            Conta c3 = new ContaEmpresarial(1003, "Roberto", 200.00, 1000.00);

            Console.WriteLine("Saldo inicial da conta do Alex");
            Console.WriteLine(c1.Saldo);
            Console.WriteLine();
            Console.WriteLine("Saldo inicial da conta da Ana");
            Console.WriteLine(c2.Saldo);
            Console.WriteLine();
            Console.WriteLine("Saldo inicial da conta do Roberto");
            Console.WriteLine(c3.Saldo);
            Console.WriteLine();

            //Aplicando a retida de R$ 10,00 na conta do Alex e da Ana
            c1.Retirada(10.00);
            c2.Retirada(10.00);

            //Aplicando um emprestimo de R$ 100,00 na conta do Roberto
            c3.Emprestimo(100.00);

            Console.WriteLine("Saldo atualizado da conta do Alex, após a retirada");
            Console.WriteLine(c1.Saldo);
            Console.WriteLine();
            Console.WriteLine("Saldo atualizado da conta da Ana , após a retirada");
            Console.WriteLine(c2.Saldo);
            Console.WriteLine();
            Console.WriteLine("Saldo atualizado da conta do Roberto , após ao acrescimo do emprestimo");
            Console.WriteLine(c3.Saldo);




        }
    }
}
