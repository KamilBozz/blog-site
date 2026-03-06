using Microsoft.EntityFrameworkCore;
using blogSite.Models;

namespace blogSite.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    public DbSet<Post> Post { get; set; } = default!; // database table

}