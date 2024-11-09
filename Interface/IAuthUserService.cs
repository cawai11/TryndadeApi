using TryndadeApi.Models;

namespace TryndadeApi.Interface
{
    public interface IAuthUserService
    {
        Task<AuthUsers> AuthUsers(string username, string password);
        string GenerateToken(string username);
    }
}
