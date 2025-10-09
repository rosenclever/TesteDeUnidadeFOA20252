using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customer
    {
        private string _name;
        private string _phone;

        public Customer(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }

        public string Name 
        { 
            get => _name; 
            private set => _name = value; 
        }
        public string Phone 
        { 
            get => _phone; 
            set => _phone = value; 
        }
    }
}
