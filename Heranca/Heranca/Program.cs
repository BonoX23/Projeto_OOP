using Heranca.Entidades;
using System;

namespace Heranca.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Conta> list = new Dictionary<string,Conta>();

            Console.WriteLine("Quantas contas deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string type = "";
                while
                    (type != "c" && type != "p" && type != "e")
                {
                    Console.WriteLine("\nConta Corrente, Poupança ou Empresarial?? Digitar (C / P / E)");
                    type = Console.ReadLine().ToLower();
                }
                
                Console.WriteLine($"\nQual o numero da conta #{i}?");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("\nQual o nome do titular?");
                string titular = Console.ReadLine();
                Console.WriteLine("\nQual o saldo inicial? ex: 0.00");
                double saldo = double.Parse(Console.ReadLine());

                switch (type.ToLower())
                {
                    case "c":
                        {
                            list.Add("c", new Conta(numero, titular, saldo));
                        };
                        break;

                    case "p":
                        {
                            Console.WriteLine("\nQual a taxa de juros?");
                            double taxaDeJuros = double.Parse(Console.ReadLine());
                            list.Add("p", new ContaPoupanca(numero, titular, saldo, taxaDeJuros));
                        };
                        break;

                    case "e":
                        {
                            Console.WriteLine("\nQual o limite de crédito?");
                            double limiteDeEmprestimo = double.Parse(Console.ReadLine());
                            list.Add("e", new ContaEmpresarial(numero, titular, saldo, limiteDeEmprestimo));
                        };
                        break;

                    default:
                        {
                            Console.WriteLine("\nFavor digitar C / P / E) para um tipo de conta");
                      
                        };
                        break;
                }

            }
            Console.WriteLine("\nDados das contas cadastradas:");
            
            foreach (Conta conta in list.Values)
            {
                Console.WriteLine(conta.ValorAtual());
            }
            
            string OpType = "";
            while
                (OpType != "s" && OpType != "n")
            {
                Console.WriteLine("\nDeseja realizar alguma operação nas contas cadastradas? Digitar (S ou N)");
                OpType = Console.ReadLine().ToLower();
            }

            if (OpType == "s")
            {
                string AcType = "";
                while
                    (AcType != "c" && AcType != "p" && AcType != "e")
                {
                    Console.WriteLine("\nDesejar realizar a operação em conta corrente, conta poupança ou conta empresarial?? Digitar (C / P / E)");
                    AcType = Console.ReadLine().ToLower();
                }
                
                switch (AcType)
                {
                    case "c":
                        {
                            string subResp = "";
                            while
                                (subResp != "s" && subResp != "d")
                            {
                                Console.WriteLine("\nDeseja realizar saque ou deposito? Digitar (S / D)");
                                subResp = Console.ReadLine().ToLower();
                            }
                            if (subResp == "s")
                            {
                                Console.WriteLine("\nQual o valor do saque?");
                                double saque = double.Parse(Console.ReadLine());
                                list["c"].Retirada(saque);
                            }

                            else if (subResp == "d")
                            {
                                Console.WriteLine("\nQual o valor para deposito?");
                                double depos = double.Parse(Console.ReadLine());
                                list["c"].Deposito(depos);
                            }

                            else
                            {
                                Console.WriteLine("\nFavor digitar S ou D");
                            }
                        };
                        break;

                    case "p":
                        {
                            string subResp = "";
                            while
                                (subResp != "s" && subResp != "d")
                            {
                                Console.WriteLine("\nDeseja realizar saque ou deposito? Digitar (S / D)");
                                subResp = Console.ReadLine().ToLower();
                            }                            
                            if (subResp == "s")
                            {
                                Console.WriteLine("\nQual o valor do saque?");
                                double saque = double.Parse(Console.ReadLine());
                                list["p"].Retirada(saque);
                            }

                            else if (subResp == "d")
                            {
                                Console.WriteLine("\nQual o valor para deposito?");
                                double despos = double.Parse(Console.ReadLine());
                                list["p"].Deposito(despos);
                            }


                            else
                            {
                                Console.WriteLine("\nFavor digitar S ou D");
                            }
                        };
                        break;

                    case "e":
                        {
                            string subResp = "";
                            while
                                (subResp != "s" && subResp != "d" && subResp != "e")
                            {
                                Console.WriteLine("\nDeseja realizar saque deposito ou emprestimo? Digitar (S / D / E)");
                                subResp = Console.ReadLine().ToLower();
                            }
                            if (subResp == "s")
                            {
                                Console.WriteLine("\nQual o valor do saque?");
                                double saque = double.Parse(Console.ReadLine());
                                list["e"].Retirada(saque);
                            }

                            else if (subResp == "d")
                            {
                                Console.WriteLine("\nQual o valor para deposito?");
                                double despos = double.Parse(Console.ReadLine());
                                list["e"].Deposito(despos);
                            }

                            else if (subResp == "e")
                            {
                                Console.WriteLine("\nQual o valor do emprestimo?");
                                double emprest = double.Parse(Console.ReadLine());
                                list["e"].Emprestimo(emprest);
                            }


                            else
                            {
                                Console.WriteLine("\nFavor digitar S ou D");
                            }
                        };
                        break;

                    default:
                        {
                            Console.WriteLine("\nFavor digitar C / P / E) para um tipo de conta");
                        };
                        break;
                
                }

                foreach (Conta conta in list.Values)
                {
                    Console.WriteLine(conta.ValorAtual());
                }

            }

            else
            {
                foreach (Conta conta in list.Values)
                {
                    Console.WriteLine(conta.ValorAtual());
                }

                Console.WriteLine("Tenha um ótimo dia, até logo!");
            }

            

        }
    }
}
