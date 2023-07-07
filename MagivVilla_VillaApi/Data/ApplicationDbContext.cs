using MagivVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagivVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
