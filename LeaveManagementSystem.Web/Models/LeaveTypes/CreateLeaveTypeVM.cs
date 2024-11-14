using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class CreateLeaveTypeVM
    {
        [Required(ErrorMessage = "Name is required")]
        [Length(6, 30, ErrorMessage = "Invalid length")]
        public string Name { get; set; }

        [Range(1, 90)]
        public int NumberOfDays { get; set; }
    }
}
