using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

        public Client()
        {
            Addresses = new HashSet<Address>();
            Payments = new HashSet<Payment>();
        }
    }
}
