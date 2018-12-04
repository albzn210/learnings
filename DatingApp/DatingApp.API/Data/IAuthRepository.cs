using System.Threading.Tasks;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<UserForRegisterDto> Register(UserForRegisterDto userForRegisterDto);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}