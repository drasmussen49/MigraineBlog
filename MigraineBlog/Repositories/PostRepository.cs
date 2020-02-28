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
        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(p => p.Id == id);
        }

        public void Update(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }
    }
}
