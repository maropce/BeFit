using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
	public class Session
	{
		public int Id { get; set; }

		[Required]
		[Display(Name = "Start")]
		[DataType(DataType.DateTime)]
		public DateTime Start { get; set; }

		[Required]
		[Display(Name = "Koniec")]
		[DataType(DataType.DateTime)]
		public DateTime End { get; set; }

		public string? UserId { get; set; }

		public IdentityUser? User { get; set; }
	}
}