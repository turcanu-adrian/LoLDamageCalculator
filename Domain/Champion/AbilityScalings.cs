namespace Domain.Champion
{
    public class AbilityScalings : BaseEntity
    {
        public ChampionStatVariants Health { get; set; }
        public ChampionStatVariants AttackDamage { get; set; }
        public ChampionStatVariants AbilityPower { get; set; }
        public ChampionStatVariants AttackSpeed { get; set; }
        public ChampionStatVariants CriticalStrike { get; set; }
    }
}
