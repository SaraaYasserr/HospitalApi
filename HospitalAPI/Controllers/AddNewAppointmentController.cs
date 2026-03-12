using HospitalAPI.Data;
using HospitalAPI.DTOs;
using HospitalAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Controllers
{
    public class AddNewAppointmentController: ControllerBase
    {
        private readonly AppDbContext _db;
        public AddNewAppointmentController(AppDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> PostAppointment(AppointmentDto appointmentDto)
        {
            var appointment = new Appointment
            {
                Name = appointmentDto.Name,
                Age = appointmentDto.Age,
                Symptoms = appointmentDto.Symptoms,
                Number = appointmentDto.Number
            };

            _db.Appointments.Add(appointment);
            await _db.SaveChangesAsync();

            return Ok(appointment);
        }
    }
}