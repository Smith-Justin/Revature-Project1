using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Pizza> Pizzas { get; set; }
        [Required]
        public User User{ get; set; }
        [Required]
        public Location Location{ get; set; }
    }
}