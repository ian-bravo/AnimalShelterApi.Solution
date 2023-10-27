using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    [StringLength(15)]
    public string Name { get; set; }
    [Required]
    [StringLength(10)]
    public string Size { get; set; }
    [Required]
    [StringLength(10)]
    public string Sex { get; set; }
    [Required]
    [Range(0,30, ErrorMessage = "Age must be between 0 and 30.")]
    public int Age { get; set; }
  }
}