using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wariors_Omelchenko.Classes
{
    public class Warior
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public Warior(double Health, double Damage)
        {
            this.Health = Health;
            this.Damage = Damage;
        }
    }
}
