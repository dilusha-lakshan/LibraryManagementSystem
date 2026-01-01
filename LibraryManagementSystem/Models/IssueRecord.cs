using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementAPI.Models
{
    public class IssueRecord
    {
        [Key]
        public int IssueId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool IsReturned { get; set; }

        // Navigation properties
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
