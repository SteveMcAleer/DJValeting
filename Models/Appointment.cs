using System.ComponentModel.DataAnnotations;

namespace DJValeting.Models
{
    public class Appointment
    {
        public Guid? Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Name cannot be longer than 200 characters.")]
        public string Name { get; set; } = "";

        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Now.AddDays(1);

        [Required]
        public string Flexibility { get; set; } = "";

        [Required]
        public string VehicleSize { get; set; } = "";

        [Required]
        [StringLength(50, ErrorMessage = "Contact number cannot be longer than 50 characters.")]
        public string ContactNumber { get; set; } = "";

        [Required]
        [StringLength(200, ErrorMessage = "Email address cannot be longer than 200 characters.")]
        public string EmailAddress { get; set; } = "";
    }
}