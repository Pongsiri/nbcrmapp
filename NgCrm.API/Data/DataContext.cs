using Microsoft.EntityFrameworkCore;
using NgCrm.API.Models;

namespace NgCrm.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values {get;set;}
        public DbSet<User> Users {get;set;}
    }
} 