using MigraineBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private MigraineContext db;

        public PostRepository(MigraineContext db)
        {
            this.db = db;
        }
        public void Create(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
