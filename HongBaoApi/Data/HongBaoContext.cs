using Microsoft.EntityFrameworkCore;
using HongBaoApi.Models;

namespace HongBaoApi.Data
{
    public class HongBaoContext : DbContext
    {
        public HongBaoContext(DbContextOptions<HongBaoContext> options) : base(options) {}

        public DbSet<HongBao> HongBaos { get; set; } = null!;
    }
}
