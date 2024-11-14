using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypesVM>> GetLeaveTypesAsync();
    }
}