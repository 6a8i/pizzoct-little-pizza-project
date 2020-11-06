using System;
using System.Collections.Generic;
using System.Linq;
using API.Models.Client;

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

        public static implicit operator Client(CreateClient.Request post)
        {
            return new Client
            {
                Id = Guid.NewGuid(),
                Name = post?.Name,
                Document = post?.Document,
                Email = post?.Email,
                Password = post?.Password,
                PhoneNumber = post?.PhoneNumber,
                Addresses = post?.Addresses?.Select(p => new Address
                {
                    City = p?.City,
                    Id = Guid.NewGuid(),
                    Neighborhood = p?.Neighborhood,
                    Number = p?.Number,
                    Street = p?.Street
                }).ToList(),
                Payments = post?.Payaments?.Select(p => new Payment
                {
                    CardNumber = p?.CardNumber,
                    Id = Guid.NewGuid(),
                    SecurityCode = p?.SecurityCode
                }).ToList()
            };
        }
    }
}
