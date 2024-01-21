using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;
using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.DAL.Repositories
{
    public class BlogRepository:GenericRepository<Blog>,IBlogRepository
    {
        public BlogRepository(DbContextClass context) : base(context)
        {
        }
    }
}
