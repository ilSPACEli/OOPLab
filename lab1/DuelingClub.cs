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
        public readonly int MAX_TURNS = 40;

        public void HostDuel(Wizard wizard_1, Wizard wizard_2) {
            Console.WriteLine("Today we are going to vitness of a duel fight of " + wizard_1.Name + " and " + wizard_2.Name +"!");

            wizard_1.Health = 100; 
            wizard_2.Health = 100;

            List<string> turnsLog = new List<string>();
            int turns_count = 0;

            while (wizard_1.Health > 0 && wizard_2.Health > 0 && turns_count != MAX_TURNS)
            {
                turns_count++;
                turnsLog.Add("Turn " + turns_count + ". Hp: " + wizard_1.Health + "/" + wizard_2.Health);
                Spell spell_1 = wizard_1.CastRandomSpell();
                Spell spell_2 = wizard_2.CastRandomSpell();

                wizard_2.TakeDamage(spell_1.Damage);
                turnsLog.Add(wizard_1.lastLog);

                if (wizard_2.Health <= 0) break;

                wizard_1.TakeDamage(spell_2.Damage);
                turnsLog.Add(wizard_2.lastLog);
            }


            DuelResult duelResult = new DuelResult();
            duelResult.Contestants = new List<Wizard>{ wizard_1, wizard_2};
            duelResult.TurnsLog = turnsLog;
            if (turns_count == MAX_TURNS) {
                duelResult.Winner = null;
                duelResult.Loser = null;
            }
            else if (wizard_1.Health < 0)
            {
                duelResult.Winner = wizard_2;
                duelResult.Loser = wizard_1;
            }
            else {
                duelResult.Winner = wizard_1;
                duelResult.Loser = wizard_2;
            }
            wizard_1.DuelsHistory.Add(duelResult);
            wizard_2.DuelsHistory.Add(duelResult);
        }
    }
}
