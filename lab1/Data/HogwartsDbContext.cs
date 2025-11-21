using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld
{
    public class HogwartsDbContext
    {
        public List<WizardEntity> Wizards { get; set; }
        public List<SpellEntity> Spells { get; set; }
        public List<WizardSpell> WizardSpells { get; set; }
        public List<DuelHistory> DuelHistories { get; set; }

        public HogwartsDbContext()
        {
            Wizards = new List<WizardEntity>();
            Spells = new List<SpellEntity>();
            WizardSpells = new List<WizardSpell>();
            DuelHistories = new List<DuelHistory>();

            SeedData();
        }

        private void SeedData()
        {
            Wizards.Add(new WizardEntity { Id = 1, Name = "Gerald", House = "Wolf School", BaseHealth = 100, ClassType = "Witcher" });
            Wizards.Add(new WizardEntity { Id = 2, Name = "Yennefer", House = "Vengerberg Lodge", BaseHealth = 120, ClassType = "Sorceress" });

            Spells.Add(new SpellEntity { Id = 1, Name = "Igni", Damage = 15, EffectType = "Damage" });
            Spells.Add(new SpellEntity { Id = 2, Name = "Aard", Damage = 9, EffectType = "Stunning" });
            Spells.Add(new SpellEntity { Id = 3, Name = "Thunderbolt", Damage = 15, EffectType = "Stunning" });
            Spells.Add(new SpellEntity { Id = 4, Name = "Fireball", Damage = 9, EffectType = "Damage" });

            WizardSpells.Add(new WizardSpell { Id = 1, WizardId = 1, SpellId = 1 });
            WizardSpells.Add(new WizardSpell { Id = 2, WizardId = 1, SpellId = 2 });

            WizardSpells.Add(new WizardSpell { Id = 3, WizardId = 2, SpellId = 3 });
            WizardSpells.Add(new WizardSpell { Id = 4, WizardId = 2, SpellId = 4 });
        }
    }
}
