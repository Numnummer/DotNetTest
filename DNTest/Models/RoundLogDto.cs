using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoundLogDto
    {
        public int Number { get; set; }
        public string PlayerName { get; set; }
        public string MonsterName { get; set; }
        public int PlayerDiceRoll { get; set; }
        public int MonsterDiceRoll { get; set; }
        public bool IsPlayerDoDamage { get; set; }
        public bool IsMonsterDoDamage { get; set; }
        public int PlayerDamage { get; set; }
        public int MonsterDamage { get; set; }
        public int PlayerHP { get; set; }
        public int MonsterHP { get; set; }
        public int PlayerAC { get; set; }
        public int MonsterAC { get; set; }
    }
}
