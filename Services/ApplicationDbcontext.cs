using Microsoft.EntityFrameworkCore;
using PhehelloSemoko_ST10163295_PROG6212_POE.Models;

namespace PhehelloSemoko_ST10163295_PROG6212_POE.Services
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<Claims> Claims { get; set; }
    }
}
