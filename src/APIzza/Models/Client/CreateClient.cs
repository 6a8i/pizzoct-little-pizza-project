using System;
using System.Collections.Generic;

namespace API.Models.Client
{
    public class CreateClient
    {
        public class Address
        {
            public string Street { get; set; }
            public string Number { get; set; }
            public string Neighborhood { get; set; }
            public string City { get; set; }
        }

        public class Payament
        {
            public string CardNumber { get; set; }
            public string SecurityCode { get; set; }
        }

        public class Request
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Document { get; set; }
            public IList<Address> Addresses { get; set; }
            public IList<Payament> Payaments { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Response
        {

        }
    }
}
