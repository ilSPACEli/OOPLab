using System;
using System.Collections.Generic;

namespace MagicWorld
{
    public abstract class BaseDuel
    {
        protected const int MAX_TURNS = 40;

        public abstract int GetRatingStake();
        public abstract DuelResult RunDuel(Wizard w1, Wizard w2);

        protected DuelResult CreateResult(Wizard w1, Wizard w2, List<string> logs)
        {
            DuelResult result = new DuelResult
            {
                Contestants = new List<Wizard> { w1, w2 },
                TurnsLog = logs
            };

            w1.DuelsHistory.Add(result);
            w2.DuelsHistory.Add(result);
            return result;
        }
    }
}