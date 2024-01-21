using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;

namespace UnitOfWorkDemo.Web.DAL.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        
        public IUserRepository User { get; }
        public IBlogRepository Blogs { get; }

        public UnitOfWork(DbContextClass dbContext,
            IUserRepository userRepository,IBlogRepository blogRepository)
        {
            _dbContext = dbContext;
            User = userRepository;
            Blogs = blogRepository;
        }

        public int SaveUnitOfWork()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
