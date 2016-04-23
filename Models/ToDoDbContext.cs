using Microsoft.Data.Entity;

namespace ToDoList.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}