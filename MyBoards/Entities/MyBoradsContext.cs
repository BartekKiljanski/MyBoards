using Microsoft.EntityFrameworkCore;

namespace MyBoards.Entities
{
    public class MyBoradsContext : DbContext
    {
        public MyBoradsContext(DbContextOptions<MyBoradsContext> options) : base(options) 
        {

        }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
        }


    }
}
