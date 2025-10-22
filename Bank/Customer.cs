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
        private string _cpf;
        private int _yearBirth;

        public Customer(string name, string phone, string cpf, int yearBirth)
        {
            _name = name;
            _phone = phone;
            if(cpf.Length != 11)
            {
                throw new ArgumentException("O CPF deve possuir exatamente 11 dígitos");
            }
            if( (DateTime.Now.Year - yearBirth) < 18)
            {
                throw new ArgumentException("O cliente deve ser maior de idade");
            }
            _cpf = cpf;
            _yearBirth = yearBirth;
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
