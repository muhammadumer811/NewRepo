using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_Name { get; set; }

        [Range(18, 65)]
        public int Emp_Age { get; set; }

        [Required]
        [StringLength(10)]
        public string Emp_Gender { get; set; }

        [Required]
        [Phone]
        public string Emp_Mobile { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Emp_Salary { get; set; }

        [Required]
        public bool Emp_Status { get; set; }

        [ForeignKey("Department")]
        [Required(ErrorMessage ="Please Select A Department.")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
