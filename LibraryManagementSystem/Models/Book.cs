using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public int Quantity { get; set; }

        public int AvailableQuantity { get; set; }
    }
}
