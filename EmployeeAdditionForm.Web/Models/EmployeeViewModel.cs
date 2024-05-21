using EmployeeAdditionForm.Web.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAdditionForm.Web.Models
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression("^[^<>]+$",ErrorMessage = "Name Not Valid")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public Guid RoleId { get; set; }

        [ValidateNever]
        public RoleViewModel Role { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }

        public bool IsFirsetAppoinment { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime StartDate { get; set; }
       
        [RegularExpression("^[^<>]+$", ErrorMessage = "Note Not Valid")]
        [StringLength(500, ErrorMessage = "Note cannot exceed 500 characters.")]
        public string Note { get; set; }
    }
}
