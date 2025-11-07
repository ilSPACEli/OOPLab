using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;

namespace MagicWorld
{
    public class DuelResult
    {
        public Guid DuelID {  get; }

        public List<Wizard> Contestants { get; set; }

        public Wizard Winner { get; set; }

        public Wizard Loser { get; set; }

        public List<string> TurnsLog { get; set; }

        public DuelResult() {
            DuelID = Guid.NewGuid();
        }

        public DuelResult(List<Wizard> contestants, Wizard winner, Wizard loser, List<string> turnsLog) 
        {
            DuelID = Guid.NewGuid();
            Contestants = contestants;
            Winner = winner;
            Loser = loser;
            TurnsLog = turnsLog;
        }
    }
}
