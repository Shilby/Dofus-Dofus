using Microsoft.AspNetCore.Identity;

namespace Dofus.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Pseudo { get; set; } 
        public string Question_Secrete { get; set; }
        public string Reponse_Secrete { get; set; }
        public DateTime CreationDate { get; set; } 
    }
}
