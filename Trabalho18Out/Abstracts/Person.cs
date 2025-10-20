using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Models;

namespace Trabalho18Out.Abstracts
{
    public abstract class Person
    {
        private string Name { get; set; }
        private DateOnly BirhtDate { get; set; }
        private Contact Contact { get; set; }
        private Address Address { get; set; }

        public Person(string name, DateOnly birhtDate, Contact contact, Address address)
        {
            Name = name;
            BirhtDate = birhtDate;
            Contact = contact;
            Address = address;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetContactPhone(string phone)
        {
            this.Contact.SetPhone(phone);
        }

        public override string ToString()
        {
            return
                $"\nName: {Name} " +
                $"\nBirth Date: {BirhtDate} " +
                $"\nContact: {Contact} " +
                $"\nAdress: {Address} ";
        }
    }
}
