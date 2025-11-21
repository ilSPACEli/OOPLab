using MagicWorld.Repositories.Interfaces;
using MagicWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Repositories
{
    public class WizardRepository : IRepository<WizardEntity>
    {
        private readonly HogwartsDbContext _context;

        public WizardRepository(HogwartsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<WizardEntity> GetAll() => _context.Wizards;

        public WizardEntity GetById(int id) => _context.Wizards.FirstOrDefault(w => w.Id == id);

        public void Add(WizardEntity entity)
        {
            entity.Id = _context.Wizards.Count + 1;
            _context.Wizards.Add(entity);
        }

        public List<SpellEntity> GetSpellsForWizard(int wizardId)
        {
            var spellIds = _context.WizardSpells
                .Where(ws => ws.WizardId == wizardId)
                .Select(ws => ws.SpellId)
                .ToList();

            return _context.Spells.Where(s => spellIds.Contains(s.Id)).ToList();
        }
    }
}
