using DesafioAluraApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioAluraApiRest.Data
{
    public class DesafioBackendAluraContext : DbContext
    {
        public DesafioBackendAluraContext(DbContextOptions<DesafioBackendAluraContext> options):base(options)
        {

        }
        public DbSet<Video> Videos { get; set; }
    }
}
