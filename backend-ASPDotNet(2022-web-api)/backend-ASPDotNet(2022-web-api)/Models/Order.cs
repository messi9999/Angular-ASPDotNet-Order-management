using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_ASPDotNet_2022_web_api_.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
    }
}
