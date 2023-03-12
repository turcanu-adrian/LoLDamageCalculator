using Domain.Enums;
using Microsoft.EntityFrameworkCore;

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
        public ICollection<AbilityScaling> AbilityScalings { get; set; }
    }
}
