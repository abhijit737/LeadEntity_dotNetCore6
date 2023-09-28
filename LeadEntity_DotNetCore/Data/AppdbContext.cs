using LeadEntity_DotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LeadEntity_DotNetCore.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<LeadEntity>Leads { get; set; }
    }
}
