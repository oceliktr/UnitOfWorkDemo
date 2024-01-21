using UnitOfWorkDemo.Web.Business.Interfaces;
using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;
using UnitOfWorkDemo.Web.Entities;

namespace UnitOfWorkDemo.Web.Business
{
    public class BlogManager:IBlogManager
    {
        private IUnitOfWork _unitOfWork;

        public BlogManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        
        public async Task<IEnumerable<Blog>> GetAllBlogs()
        {
            var users = await _unitOfWork.Blogs.GetAll();
            return users;
        }

    }
}
