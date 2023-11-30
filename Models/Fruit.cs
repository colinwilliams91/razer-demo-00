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
        /* 
         * [DataType(DataType.Date)] Decorator/Attribute specifies the type of data in the property.
         * With this the user won't be required to enter time information in the date field.
         * Only the date will be displayed, not the time information.
         */

        // TODO: Change DataType.Date to DataType.DateTime and see what changes need to occur.
    }
}
