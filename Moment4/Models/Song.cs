using System.ComponentModel.DataAnnotations;

namespace Moment4.Models
{
    public class Song
    {
        public int ID { get; set; }

        [Required]
        public string? Artist { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public int? Length { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}