using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Models
{
    public class CommandContext:DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options):base(options)
        {

        }
       public DbSet<TodoItem> Items { get; set; }
    }
}