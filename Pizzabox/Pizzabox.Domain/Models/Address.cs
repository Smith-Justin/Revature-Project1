using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
    }
}