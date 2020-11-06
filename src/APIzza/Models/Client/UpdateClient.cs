using System;
using System.Collections.Generic;

namespace API.Models.Client
{
    public class UpdateClient
    {
        public class Address
        {
            public string Street { get; set; }
            public string Number { get; set; }
            public string Neighborhood { get; set; }
            public string City { get; set; }

        }

        public class Payment
        {
            public string CardNumber { get; set; }
            public string SecurityCode { get; set; }
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
        }

        public class Request
        {
            public Client Client { get; set; }
        }

        public class Response
        {

        }
    }
}
