using Domain.Champion;

namespace Domain.Champion
{
    public class Champion : BaseEntity
    {
        public string Name { get; set; }
        public ChampionStats ChampionStatsBase { get; set; }
        public ChampionStats ChampionStatsGrowth { get; set; }
        public ChampionAbilities ChampionAbilities { get; set; }
    }
}
