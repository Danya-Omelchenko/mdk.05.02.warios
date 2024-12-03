using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wariors_Omelchenko.Classes
{
    public class HavyAtack : Warior
    {
        public HavyAtack(double Health, double Damage) : base(Health, Damage)
        {
        }
        public override void HaveDamage(double damage)
        {
            this.Health -= damage * this.Damage;
        }
    }
}
