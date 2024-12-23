using System.ComponentModel.DataAnnotations;

namespace BeFit.Models
{
    public class Statistic
    {
        public int Id { get; set; }

        [Display(Name = "Rodzaj ćwiczenia")]
		[StringLength(100, ErrorMessage = "Długość nazwy \"Rodzaj ćwiczenia\" nie może przekraczać 100 znaków.")]
		public string ExerciseName { get; set; }

        [Display(Name = "Liczba sesji")]
        public int NumberOfSessions { get; set; }

        [Display(Name = "Najlepszy wynik")]
        public int BestResult { get; set; }
    }
}