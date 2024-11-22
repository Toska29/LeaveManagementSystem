using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services.Interfaces
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypesVM>> GetLeaveTypesAsync();
    }
}