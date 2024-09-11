using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public int FloorNumber { get; set; } 
        public bool HasElevator { get; set; } 
        public bool HasBalcony { get; set; } 
        public bool IsFurnished { get; set; }
        [ForeignKey("Proprety")]
        public int PropretyId { get; set; }
        public Proprety? Proprety { get; set; }
    }
}
