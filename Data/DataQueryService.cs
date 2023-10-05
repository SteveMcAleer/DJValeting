using AutoMapper;
using DJValeting.Entities;
using DJValeting.Models;
using Microsoft.EntityFrameworkCore;

public interface IDataQueryService
{
    List<Appointment> GetAppointments();
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
        List<AppointmentEntity> appointments = _context.Appointments
            .AsNoTracking()
            .ToList();

        return _mapper.Map<List<Appointment>>(appointments);
    }
}