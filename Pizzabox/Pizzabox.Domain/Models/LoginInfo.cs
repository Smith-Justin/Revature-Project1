using System.ComponentModel.DataAnnotations;

namespace Pizzabox.Domain.Models
{
	public class LoginInfo
	{
		public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
		public string Password { get; set; }
	}
}