using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EmployeeAdditionForm.Web.Models
{
    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public Guid RoleId { get; set; }
        [ValidateNever]
        public RoleViewModel Role { get; set; }
        public int Gender { get; set; }
        public bool IsFirstAppointment { get; set; }
        public DateTime StartDate { get; set; }
        public string Note { get; set; }
    }
}
