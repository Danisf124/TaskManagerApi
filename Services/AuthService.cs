using TaskManager.Models;
using TaskManager.Models.DTO;

namespace TaskManager.Services
{
    public class AuthService : IAuthService
    {
        private int _nextId = 1;
        private List<User> _users = new List<User>()
        {
            new User{Id = 1, Email = "someone@gmail.com", PasswordHash = "GND14fkhshHjfsfdsfe"}
        };
        
        public bool AddUser(CreateUserDto createDto)
        {
            foreach(var u in _users)
            {
                if(u.Email == createDto.Email)
                {
                    return false; //Conflict
                }
            }

            var newUser = new User
            {
                Id = ++_nextId,
                Email = createDto.Email,
                PasswordHash = createDto.Password // Add Password hashing
            };

            _users.Add(newUser);
            return true;
        }

        public User GetUser(int userId)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if(user != null)
                return user;

            return null;
        }

    }
}