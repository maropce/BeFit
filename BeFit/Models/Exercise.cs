using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
	public class Exercise
	{
		[Display(Name = "ID")]
		public int Id { get; set; }

		[Display(Name = "Waga")]
		[Range(1, 500, ErrorMessage = "Waga musi być w zakresie od 1 do 500 kg.")]
		public int Weight { get; set; }

		[Display(Name = "Liczba serii")]
		[Range(1, 100, ErrorMessage = "Liczba serii musi być w zakresie od 1 do 100.")]
		public int NumberOfSeries { get; set; }

		[Display(Name = "Liczba powtórzeń")]
		[Range(1, 1000, ErrorMessage = "Liczba powtórzeń musi być w zakresie od 1 do 1000.")]
		public int NumberOfReps { get; set; }

		[Display(Name = "Rodzaj ćwiczenia")]
		[Required(ErrorMessage = "Rodzaj ćwiczenia jest wymagany.")]
		public int ExerciseTypeID { get; set; }

		[Display(Name = "Rodzaj ćwiczenia")]
		public virtual ExerciseType? ExerciseType { get; set; }

		[Display(Name = "Sesja")]
		[Required(ErrorMessage = "Sesja jest wymagana.")]
		public int SessionId { get; set; }

		[Display(Name = "Sesja")]
		public virtual Session? Session { get; set; }
	}
}
