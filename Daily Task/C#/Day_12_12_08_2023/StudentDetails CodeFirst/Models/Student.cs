using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetails.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rollno  { get; set; }

        [Required]
        public string? StudName { get; set; }

        [Required]
        public string? Address { get; set; }
       
        [Required]
        public long Phno { get; set; }
    }
}
