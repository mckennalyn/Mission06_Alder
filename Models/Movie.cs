
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Alder.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } 

        [Required]

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Title: Field Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year: Field Required")]
        [Range(1888, int.MaxValue, ErrorMessage = "Movies weren't out before 1888!")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited: Field Required")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "CopiedToPlex: Field Required")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string? Notes { get; set; }
    }
}