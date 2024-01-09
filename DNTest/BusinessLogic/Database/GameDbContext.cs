using Microsoft.EntityFrameworkCore;
using Models.Action;
using Models.ModelClasses;

namespace BusinessLogic.Database
{
    public class GameDbContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; } = null!;
        public GameDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var m1 = MonsterBuilder.Build("Monster1", "1d20");
            var m2 = MonsterBuilder.Build("Monster2", "1d8");
            var m3 = MonsterBuilder.Build("Monster3", "2d4");
            var m4 = MonsterBuilder.Build("Monster4", "1d10");
            var m5 = MonsterBuilder.Build("Monster5", "1d12");
            modelBuilder.Entity<Monster>().HasData(m1, m2, m3, m4, m5);
        }
    }
}
