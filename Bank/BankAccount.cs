using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private Customer _customer;
        private double _balance;

        public BankAccount(Customer customer, double balance)
        {
            _customer = customer;
            if (balance < 0)
            {
                throw new ArgumentException("O saldo inicial não pode ser negativo");
            }
            _balance = balance;
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
    }
}
