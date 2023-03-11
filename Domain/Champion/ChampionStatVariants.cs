using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Champion
{
    public class ChampionStatVariants : BaseEntity
    {
        public double Base { get; set; }
        public double Bonus { get; set; }
        public double Total { get; set; }
        public double Missing { get; set; }
    }
}
