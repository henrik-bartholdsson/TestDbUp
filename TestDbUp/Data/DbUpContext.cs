using Microsoft.EntityFrameworkCore;

namespace TestDbUp.Data
{
    public class DbUpContext : DbContext
    {
        public DbUpContext(DbContextOptions<DbUpContext> options) : base(options)
        {

        }
    }
}
