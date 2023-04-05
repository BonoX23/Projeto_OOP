using Heranca.Entidades;

namespace AccountTests
{
    public class ContaPoupancaTest
    {
        [Fact]
        public void TestaDeposito()
        {
            //Arrange
            var Poupanca = new ContaPoupanca("Paulo", 1000, 0.10m);

            //Act
            Poupanca.Deposit(100.00m);
            Poupanca.Deposit(100.00m);

            //Assert
            Assert.Equal(231.00m, Poupanca.Balance);
        }

        [Fact]
        public void TestaRetirada()
        {
            //Arrange
            var Poupanca = new ContaPoupanca("Paulo", 1001, 0.10m);

            //Act
            Poupanca.Retirada(10.0m);

            //Assert
            Assert.Equal(-12.0m, Poupanca.Balance);
        }
    }

    public class ContaEmpresarialTest
    {
        [Fact]
        public void TestaDeposito()
        {
            //Arrange
            var Emprestimo = new ContaEmpresarial("Antonio", 2001, 500.00m);

            //Act
            Emprestimo.Deposit(100.00m);

            //Assert
            Assert.Equal(100.00m, Emprestimo.Balance);
        }

        [Fact]
        public void TestaRetirada()
        {
            //Arrange
            var Emprestimo = new ContaEmpresarial("Antonio", 2001, 500.00m);

            //Act
            Emprestimo.Retirada(100.00m);

            //Assert
            Assert.Equal(-103.00m, Emprestimo.Balance);
        }

        [Fact]
        public void TestaEmprestimoConcedido()
        {
            //Arrange
            var Emprestimo = new ContaEmpresarial("Antonio", 2001, 500.00m);

            //Act
            Emprestimo.Emprestimo(100.00m);

            //Assert
            Assert.Equal(100.00m, Emprestimo.Balance);
        }

        [Fact]
        public void TestaEmprestimoNaoConcedido()
        {
            //Arrange
            var Emprestimo = new ContaEmpresarial("Antonio", 2001, -500.00m);

            //Act
            Emprestimo.Emprestimo(600.00m);

            //Assert
            Assert.Equal(0.00m, Emprestimo.Balance);
        }
    }
}