using System.ComponentModel.DataAnnotations;
using Models.Interfaces;

namespace Models.ModelClasses
{
    public class Player : IActor
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name must have more than 1 character")]
        public string? Name { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "HP must be in range 1-50")]
        public int HitPoints { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "AttackModifier must be in range 1-10")]
        public int AttackModifier { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "AttackPerRound must be in range 1-5")]
        public int AttackPerRound { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Damage must have more than 2 character")]
        public string? Damage { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "DamageModifier must be in range 1-5")]
        public int DamageModifier { get; set; }

        [Required]
        [Range(1, 15, ErrorMessage = "AC must be in range 1-15")]
        public int AC { get; set; }
    }
}
