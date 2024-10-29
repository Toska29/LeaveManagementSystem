using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data.Models
{
    public class LeaveType
    {
        public long Id { get; set; }

        [MaxLength(150, ErrorMessage = "lenth cannot be more than 150 characters")]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }

    }
}
