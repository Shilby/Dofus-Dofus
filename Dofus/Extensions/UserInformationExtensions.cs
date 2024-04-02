using Dofus.Migrations;
using System.Security.Claims;

namespace Dofus.Extensions
{
    public class UserInfo
    {
        public string UserId { get; set; }
        public string Pseudo { get; set; }
        public string Reponse_Secrete { get; set; }
        public string Question_Secrete { get; set; }    
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public static class UserInformationExtensions
    {
        public static UserInfo RetrieveUserInfo(this ClaimsPrincipal user)
        {
            var userInfo = new UserInfo
            {
                UserId = user.FindFirstValue("uid"),
                Pseudo = user.FindFirstValue(ClaimTypes.GivenName),
                Reponse_Secrete = user.FindFirstValue("reponse_Secrete"),
                Question_Secrete = user.FindFirstValue("question_Secrete"),
                Email = user.FindFirstValue(ClaimTypes.Email),
            };
            var creationDateClaim = user.FindFirstValue("creation_date");
            if (DateTime.TryParse(creationDateClaim, out DateTime creationDate))
            {
                userInfo.CreationDate = creationDate;
            }

            return userInfo;
        }
    }
}
