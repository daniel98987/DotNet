
using Microsoft.EntityFrameworkCore;
using study_this_framework.models;

namespace study_this_framework
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }


    }
}
