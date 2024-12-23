using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
	public class ExerciseType
	{
		public int Id { get; set; }

		[Display(Name = "Rodzaj ćwiczenia")]
		[Required(ErrorMessage = "Nazwa ćwiczenia jest wymagana.")]
		[StringLength(100, ErrorMessage = "Długość nazwy ćwiczenia nie może przekraczać 100 znaków.")]
		public string Name { get; set; }
	}
}
