using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.Build.Framework.Profiler;

namespace LeaveManagement.Web.Configurations
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<LeaveType, LeaveTypeVM>().ReverseMap(); //Convert Data Model to View Model
															  //&& Reverse Map to View Model to Data Model are Legal
		}
	}
}
