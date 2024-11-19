using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services
{
    public class LeaveTypeService(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypeService
    {
        public async Task<List<LeaveTypesVM>> GetLeaveTypesAsync()
        {
            List<Data.Models.LeaveType> leaveTypes = await _context.LeaveTypes.ToListAsync();
            var leaveTypesVM = _mapper.Map<List<LeaveTypesVM>>(leaveTypes);
            return leaveTypesVM;
        }
    }
}
