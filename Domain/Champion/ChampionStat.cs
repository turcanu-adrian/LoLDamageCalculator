using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.Champion
{
    public class ChampionStat : BaseEntity
    {
        public StatType Type { get; set; }
        public double BaseValue { get; set; }
        public double GrowthValue { get; set; }
    }
}
