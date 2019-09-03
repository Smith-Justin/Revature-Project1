using Microsoft.EntityFrameworkCore;
using Pizzabox.Domain.Models;

namespace Pizzabox.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
		public DbSet<Pizza> Pizzas { get; set; }
		public DbSet<Crust> Crusts { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<Topping> Toppings { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Name> Names { get; set; }
		public DbSet<LoginInfo> LoginInfos { get; set; }
        public DbSet<Address> Addresses { get; set; }
		public DbSet<Location> Locations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:pizzabox.database.windows.net,1433;Initial Catalog=project1db;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pizza>().HasKey(p => p.Id);
            builder.Entity<Crust>().HasKey(c => c.Id);
            builder.Entity<Size>().HasKey(s => s.Id);
            builder.Entity<Topping>().HasKey(t => t.Id);
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<Name>().HasKey(p => p.Id);
            builder.Entity<LoginInfo>().HasKey(p => p.Id);
            builder.Entity<Location>().HasKey(p => p.Id);
            builder.Entity<Address>().HasKey(p => p.Id);
            builder.Entity<Order>().HasKey(p => p.Id);

            builder.Entity<LoginInfo>().HasIndex(p => p.Email).IsUnique();
            //builder.Entity<Location>().HasIndex(p => p.Address).IsUnique();
            //builder.Entity<User>().HasIndex(p => p.LoginInfo).IsUnique();
            //builder.Entity<User>().HasIndex(p => p.Name).IsUnique();
            builder.Entity<Size>().HasIndex(p => p.Name).IsUnique();
            builder.Entity<Crust>().HasIndex(p => p.Name).IsUnique();
            builder.Entity<Topping>().HasIndex(p => p.Name).IsUnique();
            builder.Entity<Pizza>().HasOne(p => p.Size);
            builder.Entity<Pizza>().HasOne(p => p.Crust);
            builder.Entity<Pizza>().HasMany(p => p.Toppings);
        }
    }
}