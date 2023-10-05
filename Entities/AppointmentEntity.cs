namespace DJValeting.Entities
{
    public class AppointmentEntity
    {
        public Guid? Id { get; set; }

        public string Name { get; set; } = "";

        public DateTime BookingDate { get; set; }

        public string Flexibility { get; set; } = "";

        public string VehicleSize { get; set; } = "";

        public string ContactNumber { get; set; } = "";

        public string EmailAddress { get; set; } = "";
    }
}