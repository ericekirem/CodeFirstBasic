using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Models
{
    public class Movie
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }

        [Required] // Boş olamaz
        [MaxLength(100)] // Maksimum uzunluk belirteci
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required]
        public int ReleaseYear { get; set; }
    }
}
