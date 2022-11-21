using Heranca.Entidades;
using System;

namespace Heranca.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();

            Console.WriteLine("Quantas contas deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Conta Corrente, Poupança ou Empresarial (digitar c / p / e)?");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Qual o numero da conta?");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o nome do titular?");
                string titular = Console.ReadLine();
                Console.WriteLine("Qual o saldo inicial? ex: 0.00");
                double saldo = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        {
                            list.Add(new Conta(numero, titular, saldo));
                        };
                        break;

                    case 'p':
                        {
                            Console.WriteLine("Qual a taxa de juros?");
                            double taxaDeJuros = double.Parse(Console.ReadLine());
                            list.Add(new ContaPoupanca(numero, titular, saldo, taxaDeJuros));
                        };
                        break;

                    case 'e':
                        {
                            Console.WriteLine("Qual o limite de crédito?");
                            double limiteDeEmprestimo = double.Parse(Console.ReadLine());
                            list.Add(new ContaEmpresarial(numero, titular, saldo, limiteDeEmprestimo));
                        };
                        break;

                    default:
                        {
                            Console.WriteLine("Favor digitar c / p / e) para um tipo de conta");
                        };
                        break;
                }

            }
        }
    }
}
