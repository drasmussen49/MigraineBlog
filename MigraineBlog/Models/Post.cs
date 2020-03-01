using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Tag Tag { get; set; }
        public int? TagId { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }

    }
}
