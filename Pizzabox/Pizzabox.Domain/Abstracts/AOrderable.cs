using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Abstracts
{
    public abstract class AOrderable
    {
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price{ get; set; }
    }
}