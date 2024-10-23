using System.ComponentModel.DataAnnotations;

namespace PhehelloSemoko_ST10163295_PROG6212_POE.Models
{
    public class Claims
    {
        
        public int id { get; set; } 

        [MaxLength(100)]
        public string LName { get; set; } = "";

        [MaxLength(100)]
        public string LSurname {  get; set; } = "";

        [MaxLength(10)]
        public string LNumber { get; set; } = "";

        public DateOnly LStart { get; set; }

        public DateOnly LEnd { get; set; }

        [MaxLength(100)]
        public string FileName { get; set; } = "";
    }
}
