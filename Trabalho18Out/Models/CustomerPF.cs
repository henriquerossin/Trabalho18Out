using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;

namespace Trabalho18Out.Models
{
    internal class CustomerPF : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        public string CNH { get; set; }
        public string CPF { get; set; }

        public CustomerPF
            (
            string name, 
            DateOnly 
            birhtDate, 
            Contact contact, 
            Address address, 
            string Cnh, 
            string Cpf
            ) 
            : base(name, birhtDate, contact, address)
        {
            this.CNH = Cnh;
            this.CPF = Cpf;
        }
    }
}
