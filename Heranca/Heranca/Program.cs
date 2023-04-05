using Heranca.Entidades;
using Heranca.Services;
using System;

namespace Heranca.Entidades
{
    class Program
    {
        public interface IPatrimonioService
        {
            void SomaPatrimonio(List<IConta> contas);
        }

        public class PatrimonioService : IPatrimonioService
        {
            public void SomaPatrimonio(List<IConta> contas)
            {
                var patrimonio = 0m;

                foreach (IConta conta in contas)
                {
                    patrimonio += conta.Saldo();
                }

                Console.WriteLine($"O seu patrimonio total é de {patrimonio:N2}");
            }
        }

        public interface IContaService
        {
            void Saldos(params IConta[] contas);
        }

        public class ServicosDeContas : IContaService
        {
            public void Saldos(params IConta[] contas)
            {
                foreach (IConta conta in contas)
                {
                    conta.MostraSaldo();
                }
            }
        }
        static void Main(string[] args)
        {

            var contaPoupanca = new ContaPoupanca("Ricardo", 1000, 0.10m);
            contaPoupanca.Deposit(500.00m);

            var contaEmpresarial = new ContaEmpresarial("Alexandre", 1001, 200.00m);
            contaEmpresarial.Deposit(700.00m);

            var patrimonioService = new PatrimonioService();

            patrimonioService.SomaPatrimonio(new List<IConta>() { contaPoupanca, contaEmpresarial });

            //List<ContaBase> sumcontas = new List<ContaBase>();

            //sumcontas.Add(new ContaPoupanca("João", 1, 0.01m) { Balance = 100.00m });
            //sumcontas.Add(new ContaEmpresarial("Maria", 2, 5000) { Balance = 2000.00m });

            //IContaService services = new ServicosDeContas();

            //services.Saldos(contaPoupanca, contaEmpresarial);

            //decimal saldoTotal = ContaBase.SomaSaldoContas(sumcontas);

            //Console.WriteLine($"O saldo total das contas é {saldoTotal}");

            Console.ReadKey();


            //Dictionary<string, Account> list = new Dictionary<string, Account>();

            //Console.WriteLine("Quantas contas deseja cadastrar?");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    string type = "";
            //    while
            //        (type != "c" && type != "p" && type != "e")
            //    {
            //        Console.WriteLine("\nConta Corrente, Poupança ou Empresarial?? Digitar (C / P / E)");
            //        type = Console.ReadLine().ToLower();
            //    }

            //    Console.WriteLine($"\nQual o numero da conta #{i}?");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.WriteLine("\nQual o nome do titular?");
            //    string holder = Console.ReadLine();
            //    Console.WriteLine("\nQual o saldo inicial? ex: 0.00");
            //    double balance = double.Parse(Console.ReadLine());

            //    switch (type.ToLower())
            //    {
            //        case "c":
            //            {
            //                list.Add("c", new Account(number, holder, balance));
            //            };
            //            break;

            //        case "p":
            //            {
            //                Console.WriteLine("\nQual a taxa de juros?");
            //                double interestRate = double.Parse(Console.ReadLine());
            //                list.Add("p", new SavingsAccount(number, holder, balance, interestRate));
            //            };
            //            break;

            //        case "e":
            //            {
            //                Console.WriteLine("\nQual o limite de crédito?");
            //                double loanLimit = double.Parse(Console.ReadLine());
            //                list.Add("e", new BusinessAccount(number, holder, balance, loanLimit));
            //            };
            //            break;

            //        default:
            //            {
            //                Console.WriteLine("\nFavor digitar C / P / E) para um tipo de conta");

            //            };
            //            break;
            //    }

            //}
            //Console.WriteLine("\nDados das contas cadastradas:");

            //foreach (Account account in list.Values)
            //{
            //    Console.WriteLine(account.CurrentValue());
            //}

            //string OpType = "";
            //while
            //    (OpType != "s" && OpType != "n")
            //{
            //    Console.WriteLine("\nDeseja realizar alguma operação nas contas cadastradas? Digitar (S ou N)");
            //    OpType = Console.ReadLine().ToLower();
            //}

            //if (OpType == "s")
            //{
            //    string AcType = "";
            //    while
            //        (AcType != "c" && AcType != "p" && AcType != "e")
            //    {
            //        Console.WriteLine("\nDesejar realizar a operação em conta corrente, conta poupança ou conta empresarial?? Digitar (C / P / E)");
            //        AcType = Console.ReadLine().ToLower();
            //    }

            //    switch (AcType)
            //    {
            //        case "c":
            //            {
            //                string subResp = "";
            //                while
            //                    (subResp != "s" && subResp != "d")
            //                {
            //                    Console.WriteLine("\nDeseja realizar saque ou deposito? Digitar (S / D)");
            //                    subResp = Console.ReadLine().ToLower();
            //                }
            //                if (subResp == "s")
            //                {
            //                    Console.WriteLine("\nQual o valor do saque?");
            //                    double withdraw = double.Parse(Console.ReadLine());
            //                    list["c"].Withdraw(withdraw);
            //                }

            //                else if (subResp == "d")
            //                {
            //                    Console.WriteLine("\nQual o valor para deposito?");
            //                    double depos = double.Parse(Console.ReadLine());
            //                    list["c"].Deposit(depos);
            //                }

            //                else
            //                {
            //                    Console.WriteLine("\nFavor digitar S ou D");
            //                }
            //            };
            //            break;

            //        case "p":
            //            {
            //                string subResp = "";
            //                while
            //                    (subResp != "s" && subResp != "d")
            //                {
            //                    Console.WriteLine("\nDeseja realizar saque ou deposito? Digitar (S / D)");
            //                    subResp = Console.ReadLine().ToLower();
            //                }
            //                if (subResp == "s")
            //                {
            //                    Console.WriteLine("\nQual o valor do saque?");
            //                    double withdraw = double.Parse(Console.ReadLine());
            //                    list["p"].Withdraw(withdraw);
            //                }

            //                else if (subResp == "d")
            //                {
            //                    Console.WriteLine("\nQual o valor para deposito?");
            //                    double despos = double.Parse(Console.ReadLine());
            //                    list["p"].Deposit(despos);
            //                }


            //                else
            //                {
            //                    Console.WriteLine("\nFavor digitar S ou D");
            //                }
            //            };
            //            break;

            //        case "e":
            //            {
            //                string subResp = "";
            //                while
            //                    (subResp != "s" && subResp != "d" && subResp != "e")
            //                {
            //                    Console.WriteLine("\nDeseja realizar saque deposito ou emprestimo? Digitar (S / D / E)");
            //                    subResp = Console.ReadLine().ToLower();
            //                }
            //                if (subResp == "s")
            //                {
            //                    Console.WriteLine("\nQual o valor do saque?");
            //                    double withdraw = double.Parse(Console.ReadLine());
            //                    list["e"].Withdraw(withdraw);
            //                }

            //                else if (subResp == "d")
            //                {
            //                    Console.WriteLine("\nQual o valor para deposito?");
            //                    double despos = double.Parse(Console.ReadLine());
            //                    list["e"].Deposit(despos);
            //                }

            //                else if (subResp == "e")
            //                {
            //                    Console.WriteLine("\nQual o valor do emprestimo?");
            //                    double loan = double.Parse(Console.ReadLine());
            //                    list["e"].Loan(loan);
            //                }


            //                else
            //                {
            //                    Console.WriteLine("\nFavor digitar S ou D");
            //                }
            //            };
            //            break;

            //        default:
            //            {
            //                Console.WriteLine("\nFavor digitar C / P / E) para um tipo de conta");
            //            };
            //            break;

            //    }

            //    foreach (Account account in list.Values)
            //    {
            //        Console.WriteLine(account.CurrentValue());
            //    }

            //    Console.WriteLine("Tenha um ótimo dia, até logo!");
            //}

            //else
            //{
            //    foreach (Account account in list.Values)
            //    {
            //        Console.WriteLine(account.CurrentValue());
            //    }

            //    Console.WriteLine("Tenha um ótimo dia, até logo!");
            //}



        }
    }
}
