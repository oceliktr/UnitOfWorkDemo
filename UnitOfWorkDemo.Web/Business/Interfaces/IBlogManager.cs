using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.Business.Interfaces
{
    public interface IBlogManager
    {
        Task<IEnumerable<Blog>> GetAllBlogs();
    }
}
