using System;
namespace API.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string CardNumber { get; set; }
        public string SecurityCode { get; set; }

        public virtual Client Client { get; set; }

        public Payment()
        {
        }
    }
}
