using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TaskerAPI.Models
{
    public class TaskerItem
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }
       
        public bool IsComplete { get; set; }

        [Required]
        public string? UserId { get; set; }

        public virtual IdentityUser? User { get; set; }
    }
}
