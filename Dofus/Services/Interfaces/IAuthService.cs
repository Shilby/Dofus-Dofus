using Dofus.Identity;
using Microsoft.Win32;

namespace Dofus.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(Register model);
        Task<AuthModel> GetTokenAsync(LoginRequest model);
        Task<string> AddRoleAsync(AddRole model);
    }
}
