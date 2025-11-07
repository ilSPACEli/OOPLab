using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;


namespace MagicWorld
{
    public class Witcher : Wizard
    {
        public Witcher(string name, string house) : base(name, house) { }

        public override void TakeDamage(int damage)
        {
           base.TakeDamage((int)(damage * 0.9));
        }
    }
}