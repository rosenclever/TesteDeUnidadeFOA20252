using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private string _customerName;
        private double _balance;

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public string CustomerName 
        {
            get
            {
                return _customerName;
            }
            private set
            {
                _customerName = value;
            } 
        }
        public double Balance 
        {
            get => _balance; 
            private set => _balance = value;
        }
    }
}
