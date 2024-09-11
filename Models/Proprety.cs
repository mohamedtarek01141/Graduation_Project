using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
  public enum SellingType
    {
        Rent,
        Sale
    }
    public class Proprety
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string? Description { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathRooms { get; set; }

        public bool IsAvailable { get; set; }
        public bool AllowVisitRequest { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Area { get; set; }

        public SellingType SellingType { get; set; }
        public int Price { get; set; } 

        [ForeignKey("User")]
        public int Userid {get; set; }
        public User? User { get; set; }
        public List<Image>? Images { get; set; }
        public List<House>? Houses { get; set; }
        public List<Villa>? Villas { get; set; }
        public List <Apartment>? Apartments { get; set; }




}
}
