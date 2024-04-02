using System.ComponentModel.DataAnnotations;

namespace Dofus.Identity
{
    public class Register
    {
        [Required, StringLength(100)]
        public string Pseudo { get; set; }

        [Required, StringLength(100)]
        public string Question_Secrete { get; set; }

        [Required, StringLength(100)]
        public string Reponse_Secrete { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }
    }
}
