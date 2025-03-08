using HakunaMatata.Models;
using Microsoft.EntityFrameworkCore;

namespace HakunaMatata.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
