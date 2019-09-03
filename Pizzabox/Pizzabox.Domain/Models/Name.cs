using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
    public class Name
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}