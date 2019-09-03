using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
		public LoginInfo LoginInfo { get; set; }
        [Required]
        public Name Name { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}