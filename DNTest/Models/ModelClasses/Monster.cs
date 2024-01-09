using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;

namespace Models.ModelClasses
{
    public class Monster : IActor
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int HitPoints { get; set; }

        public int AttackModifier { get; set; }

        public int AttackPerRound { get; set; }

        public string? Damage { get; set; }

        public int DamageModifier { get; set; }

        public int AC { get; set; }
    }
}
