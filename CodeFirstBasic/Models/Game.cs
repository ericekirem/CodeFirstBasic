using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Models
{
    public class Game
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Platform { get; set; }

        [Required]
        [Range(0, 10)] // 0 ile 10 arasında bir değer beklenir
        public decimal Rating { get; set; }
    }
}
