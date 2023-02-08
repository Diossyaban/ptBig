using Microsoft.EntityFrameworkCore;
using PTBIG.Models;

namespace PTBIG.Data
{
    public class PTBIGContext : DbContext
    {
        public PTBIGContext(DbContextOptions<PTBIGContext> options) : base(options)
        {
        }


        public DbSet<AnakKelas11> AnakKelas11s { get; set; }

    }
}
