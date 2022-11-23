

namespace Heranca.Entidades
{
    class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros) : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxaDeJuros;
            Aplicacao();
        }

        public override void Aplicacao()
        {
            Saldo += Saldo * TaxaDeJuros;
        }

        // A baixo nós estamos fazendo a sobrescrita do metodo,
        // ou seja fazendo a retida do saldo com taxa de R$ 5,00 imposta no metodo da classe principal: Conta,
        // mais uma taxa de R$ 2,00 devido ser conta poupança.
        public override void Retirada(double quantia)
        {
            base.Retirada(quantia);
            Saldo -= 2.0;
        }

        public override string ValorAtual()
        {
            return "Numero da Conta: "
                + Numero
                + " Titular: "
                + Titular
                + " Saldo: R$"
                + Saldo.ToString("F2")
                + " Taxa de Juros de: "
                + TaxaDeJuros;
        }
    }
}
