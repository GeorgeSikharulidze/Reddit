using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace Reddit.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
        public virtual ICollection<User> UserSubscribers { get; set; } = new List<User>();

        public int? OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public virtual User? Owner { get; set; }
       
    }
}