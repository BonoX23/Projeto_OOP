namespace Heranca.Entidades
{
    class ContaEmpresarial : Conta
    {
        public double LimiteDeEmprestimo { get; set; }

       public ContaEmpresarial()
        {

        }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteDeEmprestimo) : base(numero, titular, saldo)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        //O metodo a baixo tem como objetivo de acrescentar uma quantia ao saldo,
        //caso a quantia seja menor ou igual ao limite de emprestimo.
        
        public override void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                Saldo += quantia;
            }
        }

        public override string ValorAtual()
        {
            return "Numero da Conta: "
                + Numero
                + " Titular: "
                + Titular
                + " Saldo: R$"
                + Saldo.ToString("F2")
                + " Limite de emprestimo: "
                + LimiteDeEmprestimo;
        }
    }
}
