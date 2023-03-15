using Microsoft.EntityFrameworkCore;

namespace TestAPINet.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase(databaseName: "db");
        //}
        public virtual DbSet<Employee> Employees { get; set; } 
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; }
    }
}
