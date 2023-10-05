using AutoMapper;
using DJValeting.Entities;
using DJValeting.Models;
using Microsoft.EntityFrameworkCore;

public interface IDataQueryService
{
    List<Appointment> GetAppointments();
    AppointmentEntity GetAppointmentEntity(Guid? id);
}

public class DataQueryService : IDataQueryService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;

    public DataQueryService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Appointment> GetAppointments()
    {
        List<AppointmentEntity> appointmentEntities = _context.Appointments
            .AsNoTracking()
            .ToList();

        return _mapper.Map<List<Appointment>>(appointmentEntities);
    }

    public AppointmentEntity GetAppointmentEntity(Guid? id)
    {
        AppointmentEntity appointmentEntity = new AppointmentEntity();

        if (id.HasValue)
        {
            appointmentEntity = _context.Appointments
                .AsNoTracking()
                .Where(a => a.Id == id)
                .Single();
        }

        return appointmentEntity;
    }
}