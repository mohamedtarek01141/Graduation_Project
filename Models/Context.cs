using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Graduation_Project.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Proprety> Properties { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<RequestVisit> RequestVisits { get; set; }



    }
}
