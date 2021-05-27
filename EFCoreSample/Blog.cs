using System.Collections.Generic;

namespace EFCoreSample
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
