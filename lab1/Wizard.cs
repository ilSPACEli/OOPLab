using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;

namespace MagicWorld
{
    public class Wizard
    {
        public string Name { get; set; }

        public string House { get; set; }

        public int Health { get; set; }

        public List<Spell> KnownSpells { get; set; }

        public string lastLog { get; set; }

        public List<DuelResult> DuelsHistory { get; set; }



        public Wizard(string name, string house)
        {
            Name = name;
            House = house;
            Health = 100;
            KnownSpells = new List<Spell>();
            DuelsHistory = new List<DuelResult>();
        }

        public void LearnSpell(Spell spell) {
            KnownSpells.Add(spell);
        }

        public Spell CastRandomSpell() {
            if (KnownSpells.Count() > 0)
            {
                Random rnd = new Random();
                Spell castedSpell = KnownSpells[rnd.Next(0, KnownSpells.Count())];
                GenerateLog(castedSpell);
                return castedSpell;
            }
            GenerateLog(null);
            return new Spell("", 0);
        }

        public void TakeDamage(int damage) {
            Health -= damage;
        }

        public void GenerateLog(Spell spell) {
            if (spell != null)
            {
                lastLog = Name + " casts " + spell.Name + " and deals " + spell.Damage + ((spell.Effect == Effect.None) ? "" : (" and imposes " + spell.Effect));
            }
            else {
                lastLog = Name + " has nothing to cast";
            }
        }
    }
}
