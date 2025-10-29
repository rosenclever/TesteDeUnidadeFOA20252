using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private Customer _customer;
        private decimal _balance;
        private long _number;
        private static decimal _totalBalance = 0;
        private static long _accountBiggestBalance;
        private static decimal _biggestBalance = -1;

        public BankAccount(Customer customer, long number, decimal balance)
        {
            _customer = customer;
            if (balance < 0)
            {
                throw new ArgumentException("O saldo inicial não pode ser negativo");
            }
            _balance = balance;
            _number = number;
            TotalBalance(balance);
            AccountBiggestBalance(balance, number);
        }

        public Customer Customer 
        {
            get
            {
                return _customer;
            }
            private set
            {
                _customer = value;
            } 
        }
        public decimal Balance 
        {
            get => _balance; 
            private set => _balance = value;
        }

        public long Number 
        { 
            get => _number; 
            private set => _number = value; 
        }

        public static decimal TotalBalance(decimal valor)
        {
            return _totalBalance += valor;
        }

        public static long AccountBiggestBalance(decimal balance, long number)
        {
            if(BiggestBalance < balance)
            {
                BiggestBalance = balance;
                _accountBiggestBalance = number;
            }
            return _accountBiggestBalance;
        }

        public static decimal BiggestBalance 
        { 
            get => _biggestBalance; 
            private set => value = _biggestBalance; 
        }

        public void Deposit(decimal value)
        {
            if (value < 0)
                throw new ArgumentException("O valor do deposito deverá ser positivo");
            Balance += value;
        }
    }
}
