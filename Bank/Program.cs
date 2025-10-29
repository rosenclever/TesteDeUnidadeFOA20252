using Bank;
using System.Runtime.CompilerServices;

Customer customer1 = new Customer("Rosen", "11111111", "12345678901", 2000);
BankAccount account1 = new BankAccount(customer1, 123, 10000.99m);

Console.WriteLine("O nome do cliente da conta 1 é {0}", account1.Customer.Name);

Console.WriteLine("O saldo da conta 1 é {0}", account1.Balance);

Customer customer2 = new Customer("Pedro", "2222222", "10987654321", 2004);
BankAccount account2 = new BankAccount(customer1, 654321, 2000.42m);

decimal saldoTotalInicial = account2.Balance + account1.Balance;
Console.WriteLine($"O saldo total inicial das duas contas é {saldoTotalInicial}");
ViewAccountsProperties();

account2.Deposit(10000);
ViewAccountsProperties();

void ViewAccountsProperties()
{
    Console.WriteLine($"O saldo total geral é {BankAccount.TotalBalance}");

    Console.WriteLine($"A conta com maior saldo é {BankAccount.AccountBiggestBalance} cujo saldo é {BankAccount.BiggestBalance}");
}

