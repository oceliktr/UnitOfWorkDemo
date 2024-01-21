using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.Business.Interfaces
{
    public interface IUserManager
    {
        Task<bool> CreateUser(User user);

        Task<IEnumerable<User>> GetAllUser();

        Task<User> GetUserById(int userId);

        Task<bool> UpdateUser(User user);

        Task<bool> DeleteUser(int userId);
    }
}
