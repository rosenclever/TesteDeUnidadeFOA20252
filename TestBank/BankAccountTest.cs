using Bank;

namespace TestBank
{
    [TestClass]
    public sealed class BankAccountTest
    {
        [TestMethod]
        public void ChargePositiveValueTest()
        {
            //cenario
            Customer customer1 = new Customer("cliente Teste", "1122334455", "12345678901", 2000);
            BankAccount account1 = new BankAccount(customer1, 111, 1000);
            decimal valorDeposito = 500;
            decimal saldoEsperado = 1500;

            //acao
            account1.Deposit(valorDeposito);

            //verificação
            Assert.AreEqual(saldoEsperado, account1.Balance);
        }

        public void ChargeNegativeValueTest()
        {
            //cenario
            Customer customer1 = new Customer("cliente Teste", "1122334455", "12345678901", 2000);
            BankAccount account1 = new BankAccount(customer1, 111, 1000);
            decimal valorDeposito = -500;

           
            //ação e Verificacao
            Assert.ThrowsException<ArgumentException>(() => account1.Deposit(valorDeposito));
        }
    }
}
