using Domain.Champion;

namespace Domain.Champion
{
    public class Champion : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ChampionStat> ChampionStats { get; set; }
        public ICollection<Ability> ChampionAbilities { get; set; }
    }
}
