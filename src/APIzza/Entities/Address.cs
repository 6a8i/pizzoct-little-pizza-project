using System;
namespace API.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }

        public virtual Client Client { get; set; }

        public Address()
        {
        }
    }
}
