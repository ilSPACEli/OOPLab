using MagicWorld.Repositories;
using MagicWorld.Services.Interfaces;
using MagicWorld.Services.Mappers;
using MagicWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Services
{
    public class DuelService : IDuelService
    {
        private readonly WizardRepository _wizardRepo;
        private readonly DuelRepository _duelRepo;
        private readonly DuelFactory _duelFactory;

        public DuelService(WizardRepository wizardRepo, DuelRepository duelRepo)
        {
            _wizardRepo = wizardRepo;
            _duelRepo = duelRepo;
            _duelFactory = new DuelFactory();
        }

        public void RunDuel(int w1Id, int w2Id, DuelType type)
        {
            var entity1 = _wizardRepo.GetById(w1Id);
            var entity2 = _wizardRepo.GetById(w2Id);
            var spells1 = _wizardRepo.GetSpellsForWizard(w1Id);
            var spells2 = _wizardRepo.GetSpellsForWizard(w2Id);

            if (entity1 == null || entity2 == null)
            {
                Console.WriteLine("Wizards not found.");
                return;
            }

            var w1 = WizardMapper.ToDomain(entity1, spells1);
            var w2 = WizardMapper.ToDomain(entity2, spells2);

            BaseDuel duelStrategy = _duelFactory.CreateDuel(type);
            DuelResult result = duelStrategy.RunDuel(w1, w2);

            Console.WriteLine($"Winner: {result.Winner?.Name ?? "Draw"}");

            var history = new DuelHistory
            {
                WinnerId = result.Winner != null ? (result.Winner.Name == entity1.Name ? entity1.Id : entity2.Id) : (int?)null,
                LoserId = result.Loser != null ? (result.Loser.Name == entity1.Name ? entity1.Id : entity2.Id) : (int?)null,
                TurnLog = string.Join("\n", result.TurnsLog)
            };

            _duelRepo.Add(history);
        }

        public void PrintHistory()
        {
            Console.WriteLine("\n--- Global Duel History (From DB) ---");
            foreach (var h in _duelRepo.GetAll())
            {
                string winner = h.WinnerId.HasValue ? h.WinnerId.ToString() : "Draw";
                Console.WriteLine($"Duel ID: {h.Id} | Date: {h.Date} | Winner ID: {winner}");
            }
        }
    }
}
