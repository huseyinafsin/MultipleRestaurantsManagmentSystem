using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using User = EntityLayer.Concrete.User;

namespace DataAccessLayer.Concrete
{
    public class RestaurantContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HAFSIN;Initial Catalog=MRMP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        //{

        //}
   

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodAdded> FoodAddeds { get; set; }
        public virtual DbSet<Category> FoodCategories { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<Content> FoodContents { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> UserAddresses { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
