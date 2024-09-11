namespace Graduation_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; } 
        public DateTime CreatedDate { get; set; }

        public List<Proprety>? Propreties { get; set; }
    }
}
