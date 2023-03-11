using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Champion
{
    public class Ability : BaseEntity
    {
        public double Level { get; set; }
        public DamageType DamageType { get; set; }
        public double[] Cooldown { get; set; }
        public double[] ManaCost { get; set; }
        public bool AppliesOnHits { get; set; }
        public bool OnHitScaling { get; set; }
        public AbilityScalings DamageScalings { get; set; }
        public AbilityScalings HealScalings { get; set; }
        public AbilityScalings ShieldScalings { get; set; }
    }
}
