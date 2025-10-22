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
        private double _balance;
        private long _number;
        private static double _saldoTotal = 0;
        private static long _ContaMaiorSaldo;
        private static double _MaiorSaldo = -1;

        public BankAccount(Customer customer, long number, double balance)
        {
            _customer = customer;
            if (balance < 0)
            {
                throw new ArgumentException("O saldo inicial não pode ser negativo");
            }
            _balance = balance;
            _number = number;
            SaldoTotal(balance);
            ContaMaiorSaldo(balance, number);
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
        public double Balance 
        {
            get => _balance; 
            private set => _balance = value;
        }

        public long Number 
        { 
            get => _number; 
            private set => _number = value; 
        }

        public static double SaldoTotal(double valor)
        {
            return _saldoTotal += valor;
        }

        public static long ContaMaiorSaldo(double balance, long number)
        {
            if(MaiorSaldo < balance)
            {
                MaiorSaldo = balance;
                _ContaMaiorSaldo = number;
            }
            return _ContaMaiorSaldo;
        }

        public static double MaiorSaldo 
        { 
            get => _MaiorSaldo; 
            private set => value = _MaiorSaldo; 
        }

        public void Charge(double value)
        {
            Balance += value;
        }
    }
}
