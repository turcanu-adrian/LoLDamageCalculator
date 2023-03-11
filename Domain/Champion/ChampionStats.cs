using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Champion
{
    public class ChampionStats : BaseEntity
    {
        public double Health { get; set; }
        public double HealthRegen { get; set; }
        public double Armor { get; set; }
        public double MagicResist { get; set; }
        public double MovementSpeed { get; set; }
        public double Mana { get; set; }
        public double ManaRegen { get; set; }
        public double AttackDamage { get; set; }
        public double CritDamage { get; set; }
        public double AttackSpeed { get; set; }
    }
}
