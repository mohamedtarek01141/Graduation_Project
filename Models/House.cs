using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public class House 
    {
        public int Id { get; set; }
        public bool HasGarage { get; set; } 
        public bool HasGarden { get; set; } 
        public int NumberOfFloors { get; set; }
        [ForeignKey("Proprety")]
        public int PropretyId { get; set; }
        public Proprety? Proprety { get; set; }

    }
}
