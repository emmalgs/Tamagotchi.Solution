using Microsoft.EntityFrameworkCore;

namespace Tamagotchi.Data
{
  public class TamagotchiContext : DbContext
  {
    public DbSet<PetEntity> Pets { get; set; }
    public TamagotchiContext(DbContextOptions options) : base(options) { }
  }
}