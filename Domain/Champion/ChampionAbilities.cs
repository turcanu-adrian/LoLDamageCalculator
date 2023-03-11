
namespace Domain.Champion
{
    public class ChampionAbilities : BaseEntity
    {
        public Ability Passive { get; set; }
        public Ability Q { get; set; }
        public Ability W { get; set; }
        public Ability E { get; set; }
        public Ability R { get; set; }
    }
}
