namespace Heranca.Entidades
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

       public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //O metodo a baixo tem como objetivo de acrescentar uma quantia ao saldo,
        //caso a quantia seja menor ou igual ao limite de emprestimo.
        
        public override void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string CurrentValue()
        {
            return "Numero da Conta: "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo atual: R$"
                + Balance.ToString("F2")
                + ", Limite de emprestimo: "
                + LoanLimit;
        }
    }
}
