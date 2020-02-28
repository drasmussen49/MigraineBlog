using MigraineBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private MigraineContext db;

        public CategoryRepository(MigraineContext db)
        {
            this.db = db;
        }
        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
