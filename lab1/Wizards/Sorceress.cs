using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWorld;


namespace MagicWorld
{
    public class Sorceress : Wizard
    {
        public Sorceress(string name, string house) : base(name, house)
        {
            Health = 120;
        }
    }
}