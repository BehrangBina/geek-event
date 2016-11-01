using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GeekEvent.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //add the model
        public DbSet<Gig> Gigs { get; set; }
        //2 - we wanna query genre so we add it
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}