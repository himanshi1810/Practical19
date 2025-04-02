using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Practical19.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
