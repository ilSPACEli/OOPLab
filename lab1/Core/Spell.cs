using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;

namespace MagicWorld
{
    public enum Effect {
        None,
        Disarming = 0,
        Stunning = 1,
        Damage = 2,
    }

    public class Spell
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public Effect Effect { get; set; }

        public Spell(string name, int damage) {
            Name = name;
            Damage = damage;
            Effect = Effect.None; 
        }

        public Spell(string name, int damage, Effect effect)
        {
            Name = name;
            Damage = damage;
            Effect = effect;
        }
    }
}
