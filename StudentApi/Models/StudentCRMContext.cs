using Microsoft.EntityFrameworkCore;

namespace StudentApi.Models
{
    public class StudentCRMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-4848NTT\\MSSQLSERVER01; Database=StudentCRM2;trusted_connection=true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }   
        public DbSet<Country> Country { get; set; }

        public DbSet<University> University { get; set; }


    }
}
