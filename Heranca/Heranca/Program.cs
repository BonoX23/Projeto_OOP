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

            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine("Conta Corrente, Poupança ou Empresarial? Digitar C / P / E)?");
                string type = Console.ReadLine();
                Console.WriteLine("Qual o numero da conta?");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o nome do titular?");
                string titular = Console.ReadLine();
                Console.WriteLine("Qual o saldo inicial? ex: 0.00");
                double saldo = double.Parse(Console.ReadLine());

                switch (type.ToLower())
                {
                    case "c":
                        {
                            list.Add(new Conta(numero, titular, saldo));
                        };
                        break;

                    case "p":
                        {
                            Console.WriteLine("Qual a taxa de juros?");
                            double taxaDeJuros = double.Parse(Console.ReadLine());
                            list.Add(new ContaPoupanca(numero, titular, saldo, taxaDeJuros));
                        };
                        break;

                    case "e":
                        {
                            Console.WriteLine("Qual o limite de crédito?");
                            double limiteDeEmprestimo = double.Parse(Console.ReadLine());
                            list.Add(new ContaEmpresarial(numero, titular, saldo, limiteDeEmprestimo));
                        };
                        break;

                    default:
                        {
                            Console.WriteLine("Favor digitar C / P / E) para um tipo de conta");
                        };
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Dados das contas cadastradas:");
            foreach (Conta conta in list)
            {
                Console.WriteLine(conta.ContaInicial());
            }

            Console.WriteLine("Deseja realizar saque ou deposito em alguma das contas cadastradas? Digitar (S ou N)");
            string OpType = Console.ReadLine().ToLower();

            if (OpType == "s")
            {
                Console.WriteLine("Desejar realizar a operação em conta corrente, conta poupança ou conta empresarial?? Digitar (C / P / E)");
                string AcType = Console.ReadLine().ToLower();

                switch (AcType.ToLower())
                {
                    case "c":
                        {
                            Console.WriteLine("Deseja realizar saque ou deposito? Digitar (S / D)");
                            string subResp = Console.ReadLine().ToLower();
                            if (subResp == "s")
                            {
                                Console.WriteLine("Qual o valor do saque?");
                                double saque1 = double.Parse(Console.ReadLine());
                                Conta.Retirada(saque1); // Vc parou Aqui
                            }
                        };
                        break;

                    case "p":
                        {
                            Console.WriteLine("Qual a taxa de juros?");
                            double taxaDeJuros = double.Parse(Console.ReadLine());
                            list.Add(new ContaPoupanca(numero, titular, saldo, taxaDeJuros));
                        };
                        break;

                    case "e":
                        {
                            Console.WriteLine("Qual o limite de crédito?");
                            double limiteDeEmprestimo = double.Parse(Console.ReadLine());
                            list.Add(new ContaEmpresarial(numero, titular, saldo, limiteDeEmprestimo));
                        };
                        break;

                    default:
                        {
                            Console.WriteLine("Favor digitar C / P / E) para um tipo de conta");
                        };
                        break;



                }

        }
    }
}
