using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.Champion
{
    public class AbilityScaling : BaseEntity
    {
        public StatType StatType { get; set; }
        public double Base { get; set; }
        public double Bonus { get; set; }
        public double Total { get; set; }
        public double Missing { get; set; }
    }
}
