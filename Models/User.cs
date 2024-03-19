using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reddit.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        [InverseProperty("Owner")]
        public virtual ICollection<Community> Communities { get; set; } = new List<Community>();
    }
}