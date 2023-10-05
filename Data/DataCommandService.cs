using AutoMapper;
using DJValeting.Entities;
using DJValeting.Models;

public interface IDataCommandService
{
    void CreateAppointment(Appointment appointment);
    void ApproveAppointment(Guid? id);
}

public class DataCommandService : IDataCommandService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    protected readonly IDataQueryService _dataQueryService;

    public DataCommandService(DataContext context, IMapper mapper, IDataQueryService dataQueryService)
    {
        _context = context;
        _mapper = mapper;
        _dataQueryService = dataQueryService;
    }

    public void CreateAppointment(Appointment appointment)
    {
        AppointmentEntity appointmentEntity = _mapper.Map<AppointmentEntity>(appointment);

        appointmentEntity.Id = Guid.NewGuid();

        _context.Appointments.Add(appointmentEntity);

        _context.SaveChanges();
    }

    public void ApproveAppointment(Guid? id)
    {
        if (id.HasValue)
        {
            AppointmentEntity appointmentEntity = _dataQueryService.GetAppointmentEntity(id);

            appointmentEntity.Approved = true;

            _context.Appointments.Update(appointmentEntity);

            _context.SaveChanges();
        }
    }
}