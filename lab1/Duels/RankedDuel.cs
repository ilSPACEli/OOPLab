using System;
using System.Collections.Generic;
using MagicWorld;

namespace MagicWorld
{
    public class RankedDuel : BaseDuel
    {
        public override int GetRatingStake() => 25;

        public override DuelResult RunDuel(Wizard w1, Wizard w2)
        {
            Console.WriteLine($"[RANKED] Duel between {w1.Name} and {w2.Name} for {GetRatingStake()} points!");
            w1.Health = 100; w2.Health = 100;
            List<string> turnsLog = new List<string>();
            int turns = 0;

            while (w1.Health > 0 && w2.Health > 0 && turns < MAX_TURNS)
            {
                turns++;
                turnsLog.Add($"T{turns}: {w1.Name}({w1.Health}) vs {w2.Name}({w2.Health})");
                Spell s1 = w1.CastRandomSpell();
                Spell s2 = w2.CastRandomSpell();
                w2.TakeDamage(s1.Damage);
                w1.TakeDamage(s2.Damage);
                turnsLog.Add($"  -> {w1.lastLog} | {w2.lastLog}");
            }

            DuelResult result = CreateResult(w1, w2, turnsLog);

            if (w1.Health <= 0 && w2.Health <= 0)
            {
                result.Winner = null;
            }
            else if (w1.Health <= 0)
            {
                result.Winner = w2;
                result.Loser = w1;
            }
            else if (w2.Health <= 0)
            {
                result.Winner = w1;
                result.Loser = w2;
            }
            else
            {
                result.Winner = null;
            }

            return result;
        }
    }
}