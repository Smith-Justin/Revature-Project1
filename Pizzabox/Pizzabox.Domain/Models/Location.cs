using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        public Address Address { get; set; }
        //public List<Order> OrderHistory { get; set; }
        //public List<Order> CurrentOrders { get; set; }
    }
}