using Microsoft.EntityFrameworkCore;
using SingletonPattern.Models;

namespace SingletonPattern.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
           
        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientCreate> PatientCreates { get; set; }
    }
}
