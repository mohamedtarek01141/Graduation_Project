using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrimary { get; set; }

        [ForeignKey("Proprety")]
        public int PropertyId { get; set; }
        public Proprety? Proprety { get; set; }

    }
}
