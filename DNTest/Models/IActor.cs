using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IActor
    {
        string Damage { get; set; }
        int AttackModifier { get; set; }
        int DamageModifier { get; set; }
        int AttackPerRound { get; set; }
        int AC { get; set; }
    }
}
