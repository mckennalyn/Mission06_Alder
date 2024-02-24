
using System.ComponentModel.DataAnnotations;

namespace Mission06_Alder.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieCategory { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieTitle { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int MovieYear { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieDirector { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string MovieRating { get; set; }

        public bool? MovieEdited { get; set; }
        public string? MovieLent { get; set; }

        [StringLength(25, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string? MovieNotes { get; set; }

    }
}