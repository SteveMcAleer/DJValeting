using AutoMapper;
using DJValeting.Entities;
using DJValeting.Models;

public interface IDataCommandService
{
    void CreateAppointment(Appointment appointment);
}

public class DataCommandService : IDataCommandService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;

    public DataCommandService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void CreateAppointment(Appointment appointment)
    {
        AppointmentEntity appointmentEntity = _mapper.Map<AppointmentEntity>(appointment);

        appointmentEntity.Id = Guid.NewGuid();

        _context.Appointments.Add(appointmentEntity);

        _context.SaveChanges();
    }
}