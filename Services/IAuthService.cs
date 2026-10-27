using TaskManager.Models;
using TaskManager.Models.DTO;


namespace TaskManager.Services
{
    public interface IAuthService
    {
        public bool AddUser(CreateUserDto createDto);
        public User GetUser(int userId);
    }
}