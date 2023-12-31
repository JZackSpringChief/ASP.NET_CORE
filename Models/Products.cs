// #nullable disable this is a way to disable nullable checks
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HPlusSport.API.Models;
public class Product
{
    public int Id { get; set; }
    [Required]
    public string? SKU { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

    [Required]
    public int CategoryId { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }
}