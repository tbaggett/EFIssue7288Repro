using System.ComponentModel.DataAnnotations.Schema;

namespace EFIssue7288Repro.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}