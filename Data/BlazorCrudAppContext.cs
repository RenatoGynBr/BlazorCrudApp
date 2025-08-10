using BlazorCrudApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorCrudApp.Data
{
    public class BlazorCrudAppContext : DbContext
    {
        public BlazorCrudAppContext (DbContextOptions<BlazorCrudAppContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
    }
}
