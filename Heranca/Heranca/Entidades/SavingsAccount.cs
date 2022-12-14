

namespace Heranca.Entidades
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
            UpdateBalance();
        }

        public override void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // A baixo nós estamos fazendo a sobrescrita do metodo,
        // ou seja fazendo a retida do saldo com taxa de R$ 5,00 imposta no metodo da classe principal: Conta,
        // mais uma taxa de R$ 2,00 devido ser conta poupança.
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

        public override string CurrentValue()
        {
            return "Numero da Conta: "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo atual: R$"
                + Balance.ToString("F2")
                + ", Taxa de Juros de: "
                + InterestRate;
        }
    }
}
