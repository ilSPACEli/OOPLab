using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Services.Views {
    public class WizardView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string House { get; set; }
        public int Health { get; set; }
        public List<SpellView> Spells { get; set; } = new List<SpellView>();
    }
}
