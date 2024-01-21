using UnitOfWorkDemo.Web.Business.Interfaces;
using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;
using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.Business
{
    public class UserManager:IUserManager
    {
        public IUnitOfWork _unitOfWork;

        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateUser(User user)
        {
            if (user != null)
            {
                await _unitOfWork.User.Add(user);

                var result = _unitOfWork.SaveUnitOfWork();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
          var users = await _unitOfWork.User.GetAll();
           return users;
        }

        public Task<User> GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
