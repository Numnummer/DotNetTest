using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class MonsterBuilder
    {
        public static Monster Build(string name, string damage)
        {
            var random = new Random();
            return new Monster()
            {
                Id=Guid.NewGuid(),
                Name = name,
                HitPoints=random.Next(1, 51),
                AttackModifier=random.Next(1, 11),
                AttackPerRound=random.Next(1, 6),
                Damage=damage,
                DamageModifier=random.Next(1, 6),
                AC=random.Next(1, 16)
            };
        }
    }
}
