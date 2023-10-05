using AutoMapper;
using DJValeting.Entities;

namespace DJValeting.Models
{
    public class AppointmentMappingProfile : Profile
    {
        public AppointmentMappingProfile()
        {
            CreateMap<Appointment, AppointmentEntity>();
            
            CreateMap<AppointmentEntity, Appointment>();
        }
    }
}