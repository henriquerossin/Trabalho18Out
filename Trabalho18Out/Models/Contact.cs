namespace Trabalho18Out.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public string? Phone { get; set; }
        public Contact
            (
            string email,
            string? phone
            )
        {
            this.Email = email;
            this.Phone = phone;
        }

        public void SetPhone(string phone)
        {
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"Email: {this.Email} \nPhone: {this.Phone}";
        }
    }
}
