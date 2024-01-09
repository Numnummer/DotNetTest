﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Player
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
        [Range(1, 10, ErrorMessage = "Damage must be in range 1-10")]
        public int Damage { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "DamageModifier must be in range 1-5")]
        public int DamageModifier { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "AC must be in range 1-25")]
        public int AC { get; set; }
    }
}
