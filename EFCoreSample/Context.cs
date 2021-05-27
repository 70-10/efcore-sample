using Microsoft.EntityFrameworkCore;

namespace EFCoreSample
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=db.local;Database=SampleDB;User Id=SA;Password=Password123;");
    }
}
