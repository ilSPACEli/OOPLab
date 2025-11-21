using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld
{
    public class DuelHistory
    {
        public int Id { get; set; }
        public int? WinnerId { get; set; }
        public int? LoserId { get; set; }
        public string TurnLog { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
