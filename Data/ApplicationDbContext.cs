using HospitalApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
