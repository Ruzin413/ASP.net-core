using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mystore.Models
{
    public class Employee
    {
        [Key]
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Character length must be 3 to 15 letters long")]
        [Column("FormName", TypeName = "varchar(100)")]
        public string FormName { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email", TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
        [Column("FormAge", TypeName = "int")]
        public int FormAge { get; set; }

        [Required]
        [Column("FormGender", TypeName = "varchar(10)")]
        public Gender Gender { get; set; }

        [Required]
        [Column("MarriedStatus", TypeName = "varchar(10)")]
        public string Married { get; set; }

        [Required]
        [Column("FormTextArea", TypeName = "varchar(500)")]
        public string FormTextArea { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
