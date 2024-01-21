using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;
using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.DAL.Repositories
{
    //: GenericRepository<ProductDetails>, IProductRepository
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(DbContextClass context) : base(context)
        {
        }
    }
}
