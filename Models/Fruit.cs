using System.ComponentModel.DataAnnotations;

namespace razer_demo_00.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)] public DateTime CreatedAt { get; set; }
    }
}
