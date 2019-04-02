using System.Threading.Tasks;
using DatingApi.Models;

namespace DatingApi.Repositories
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
        
    }
}