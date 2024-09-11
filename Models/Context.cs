using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;
namespace Graduation_Project.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Villa> villas { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<RequestVisit> RequestVisits { get; set; }



    }
}
