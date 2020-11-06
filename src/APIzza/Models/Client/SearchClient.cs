using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Models.Client
{
    public class SearchClient
    {
        public class Address
        {
            public string Street { get; set; }
            public string Number { get; set; }
            public string Neighborhood { get; set; }
            public string City { get; set; }

            public static implicit operator Address(Entities.Address entity)
            {
                return new Address
                {
                    City = entity.City,
                    Neighborhood = entity.Neighborhood,
                    Number = entity.Number,
                    Street = entity.Street
                };
            }
        }

        public class Payment
        {
            public string CardNumber { get; set; }
            public string SecurityCode { get; set; }

            public static implicit operator Payment(Entities.Payment entity)
            {
                return new Payment
                {
                    CardNumber = entity.CardNumber,
                    SecurityCode = entity.SecurityCode
                };
            }
        }

        public class Client
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Document { get; set; }
            public ICollection<Address> Addresses { get; set; }
            public ICollection<Payment> Payaments { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

            public static implicit operator Client(Entities.Client entity)
            {
                return new Client
                {
                    Name = entity.Name,
                    Email = entity.Email,
                    Document = entity.Document,
                    Password = entity.Password,
                    PhoneNumber = entity.PhoneNumber,
                    Addresses = entity.Addresses.Select<Entities.Address, Address>(e => e).ToList(),
                    Payaments = entity.Payments.Select<Entities.Payment, Payment>(e => e).ToList(),
                };
            }
        }

        public class Request
        {
            
        }

        public class Response
        {
            public ICollection<Client> Clients { get; set; }

            public Response()
            {
                Clients = new HashSet<Client>();
            }
        }
    }
}
