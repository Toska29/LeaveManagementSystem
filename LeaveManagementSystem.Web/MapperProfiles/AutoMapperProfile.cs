using AutoMapper;
using LeaveManagementSystem.Web.Data.Models;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypesVM>();
            //.ForMember(dest => dest.NumberOfDays, opt => opt.MapFrom(src => src.NumberOfDays));
            CreateMap<CreateLeaveTypeVM, LeaveType>();
        }
    }
}
