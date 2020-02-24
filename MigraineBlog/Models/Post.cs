using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        //public Category Category { get; set; }
        //public ICollection<Tag> Tag { get; set; }

    }
}
