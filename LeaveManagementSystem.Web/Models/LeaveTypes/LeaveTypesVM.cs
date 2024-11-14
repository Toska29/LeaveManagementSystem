using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypesVM
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public int? NumberOfDays { get; set; }
    }
}
