using MagicWorld.Services.Views;
using MagicWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Services.Mappers { 
    public static class WizardMapper
    {

        public static Wizard ToDomain(WizardEntity entity, List<SpellEntity> spells)
        {
            Wizard domainWizard;
            if (entity.ClassType == "Witcher")
                domainWizard = new Witcher(entity.Name, entity.House);
            else
                domainWizard = new Sorceress(entity.Name, entity.House);

            domainWizard.Health = entity.BaseHealth;

            foreach (var s in spells)
            {
                domainWizard.LearnSpell(new Spell(s.Name, s.Damage, Effect.Damage));
            }
            return domainWizard;
        }
    }
}
