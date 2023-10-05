using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJValeting.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateApopintmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    BookingDate = table.Column<DateTime>(nullable: true),
                    Flexibility = table.Column<string>(maxLength: 50, nullable: true),
                    VehicleSize = table.Column<string>(maxLength: 50, nullable: true),
                    ContactNumber = table.Column<string>(maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}