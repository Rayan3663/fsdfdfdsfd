using foodOrderingSystem.models;
using System;

namespace foodOrderingSystem.data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Users> user { get; set; }
        public DbSet<Products> product { get; set; }
        public DbSet<OrderDetails> orders { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Character> characters { get; set; }
        public DbSet<BackPack> backpacks { get; set; }
        public DbSet<Faction> factions { get; set; }
        public DbSet<Weapon> weapons { get; set; }
    }
}
