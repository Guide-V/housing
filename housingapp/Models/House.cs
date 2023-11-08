using System.ComponentModel.DataAnnotations;

namespace housingapp.Models;

public class House
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public int BedroomCount { get; set; }
    public int BathroomCount { get; set; }
    public int FloorCount { get; set; }
    public bool HasBasement { get; set; }
    public decimal Area { get; set; }
    public decimal Price { get; set; }
}