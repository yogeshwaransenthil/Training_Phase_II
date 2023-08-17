using JWTAuth.Models;
namespace JWTAuth.Service

{
    public interface IUserService
    {
        Task<User> GetUserByUsername(string username);
        Task<List<User>> AddUserTable(User user);
        Task<User> UpdateUser(string username, User user);
        Task<List<User>> DeleteUser(string username);

    }
}
