using Bank;

Customer customer1 = new Customer("Rosen", "11111111");
BankAccount account1 = new BankAccount(customer1, 123, 1000000.99);

Console.WriteLine("O nome do cliente da conta 1 é ", account1.Customer.Name);

Console.WriteLine("O saldo da conta 1 é ", account1.Balance);

Customer customer2 = new Customer("Pedro", "2222222");
BankAccount account2 = new BankAccount(customer1, 654321, 2341.42);

double saldoTotalInicial = account2.Balance + account1.Balance;
Console.WriteLine($"O saldo total inicial das duas contas é {saldoTotalInicial}");

Console.WriteLine($"O saldo total geral é {BankAccount.SaldoTotal}");

Console.WriteLine($"A conta com maior saldo é {BankAccount.ContaMaiorSaldo} cujo saldo é {BankAccount.MaiorSaldo}");

