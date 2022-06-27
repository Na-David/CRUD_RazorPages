using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.WebSiteModels
{
    public class Blog
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
