using System.ComponentModel.DataAnnotations;

namespace Dofus.Identity
{
    public class AddRole
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
