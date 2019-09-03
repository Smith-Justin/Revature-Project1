using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public Size Size{ get; set; }
        [Required]
        public Crust Crust{ get; set; }
        [Required]
        public List<Topping> Toppings{ get; set; }
        public decimal Price{ get; set; }
    }
}