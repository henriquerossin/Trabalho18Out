using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;

namespace Trabalho18Out.Models
{
    internal class CustomerPJ : Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CNPJ { get; set; }

        public CustomerPJ
            (
            string name, 
            DateOnly birhtDate, 
            Contact contact, 
            Address address,
            string CNPJ
            ) 
            : base(name, birhtDate, contact, address)
        {
            this.CNPJ = CNPJ;
        }
    }
}
