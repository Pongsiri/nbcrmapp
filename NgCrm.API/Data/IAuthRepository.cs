using System.Threading.Tasks;
using NgCrm.API.Models;

namespace NgCrm.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string password);

        Task<User> Login(string username,string password);

        Task<bool> UserExists(string username);
        
    } 
}