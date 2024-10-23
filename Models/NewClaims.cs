using System.ComponentModel.DataAnnotations;

namespace PhehelloSemoko_ST10163295_PROG6212_POE.Models
{
    public class NewClaims
    {

        [Required, MaxLength(100)]
        public string LName { get; set; } = "";

        [Required, MaxLength(100)]
        public string LSurname { get; set; } = "";

        [Required, MaxLength(100)]
        public string LNumber { get; set; } = "";

        public DateOnly LStart { get; set; } 

        public DateOnly LEnd { get; set; }

        [Required, MaxLength(100)]
        public IFormFile? FileName { get; set; }
    }
}

