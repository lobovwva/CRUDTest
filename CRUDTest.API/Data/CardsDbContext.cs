using CRUDTest.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDTest.API.Data
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options) : base(options)
        {
        }

        // Dbset

        public DbSet<Card> Cards { get; set; }
    }
}
