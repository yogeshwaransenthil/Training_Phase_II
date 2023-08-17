using JWTAuth.Models;
using Microsoft.EntityFrameworkCore;
using JWTAuth.GlobalException;

namespace JWTAuth.Service
{
    public class UserService : IUserService
    {
        public EmployeeMgmtContext _employeeMgmtContext;

        public UserService(EmployeeMgmtContext employeeMgmtContext)
        {
            _employeeMgmtContext = employeeMgmtContext;
        }

        public async Task<List<User>> AddUserTable(User user)
        {
            if (user == null)
            {
                await _employeeMgmtContext.Users.AddAsync(user);
                await _employeeMgmtContext.SaveChangesAsync();
                return await _employeeMgmtContext.Users.ToListAsync();
            }
            else
            {
                throw new Exception(ExceptionMessage.ExceptionMessages[0]);
            }
        }

        public async Task<List<User>>DeleteUser(string username)
        {
            var ruser = await _employeeMgmtContext.Users.FindAsync(username);
            if (ruser != null)
            {
                _employeeMgmtContext.Users.Remove(ruser);
                _employeeMgmtContext.SaveChanges();
                var rusers = await _employeeMgmtContext.Users.ToListAsync();
                return rusers;
            }
            else
            {
                throw new Exception(ExceptionMessage.ExceptionMessages[0]);
            }
            
        }

        public async Task<User> GetUserByUsername(string username)
        {
            if (username == null)
            {
                var users = await _employeeMgmtContext.Users.FindAsync(username);
                return users;
            }
            else
            {
                throw new Exception(ExceptionMessage.ExceptionMessages[0]);
            }
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var ruser = await _employeeMgmtContext.Users.FindAsync(username);
            if(ruser != null)
            {
                ruser.Password = user.Password;
                ruser.Role = user.Role;
                _employeeMgmtContext.SaveChanges();
                ruser = await _employeeMgmtContext.Users.FindAsync(username);
                return ruser;
            }
            else
            {
                throw new Exception(ExceptionMessage.ExceptionMessages[0]);
            }
        }
    }
}
