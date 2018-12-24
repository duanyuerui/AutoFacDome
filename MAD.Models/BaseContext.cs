using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MAD.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("name=Default")
        {

        }

        public BaseContext(string s) : base(s)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<BaseUser> BaseUsers { get; set; }
    }
}