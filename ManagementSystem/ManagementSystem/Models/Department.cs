using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }

        [Required, StringLength(100)]
        public string Department_Name { get; set; }
    }
}
