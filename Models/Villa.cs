using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }
        public bool HasRoof { get; set; }
        [ForeignKey("Proprety")]
        public int PropretyId { get; set; }
        public Proprety? Proprety { get; set; }

    }
}

