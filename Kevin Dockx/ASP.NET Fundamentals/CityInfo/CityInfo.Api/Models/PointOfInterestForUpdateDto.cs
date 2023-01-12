using System.ComponentModel.DataAnnotations;

namespace CityInfo.Api.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Provide a name!")]
        public string Name { get; set; } = String.Empty;
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
