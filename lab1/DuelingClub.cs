using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;

namespace MagicWorld
{
    public class DuelingClub
    {
        public void HostDuel(Wizard w1, Wizard w2, BaseDuel duelStrategy)
        {
            if (w1 == null || w2 == null || duelStrategy == null) return;

            DuelResult result = duelStrategy.RunDuel(w1, w2);

            string winnerName = result.Winner?.Name ?? "Draw";
            Console.WriteLine($"Match Over! Winner: {winnerName}\n");
        }
    }
}