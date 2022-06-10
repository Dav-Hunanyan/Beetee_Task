
using Microsoft.EntityFrameworkCore;

namespace Beetee_Task.Models
{
    public class HrDataContext : DbContext
    {
        public DbSet<HrData> datas { get; set; }
        public HrDataContext(DbContextOptions<HrDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
