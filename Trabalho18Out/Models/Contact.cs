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
    }
}
