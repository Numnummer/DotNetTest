using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Monster
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int HitPoints { get; set; }

        public int AttackModifier { get; set; }

        public int AttackPerRound { get; set; }

        public int Damage { get; set; }

        public int DamageModifier { get; set; }

        public int AC { get; set; }
    }
}
