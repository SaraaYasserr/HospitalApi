using HospitalAPI.models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Medicin>Medicins { get; set; }
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Appointment> Appointments {  get; set; }
        public DbSet<Patient> Patients {  get; set; }
        public DbSet<Doctor> Doctors { get; set; }

    }
}
