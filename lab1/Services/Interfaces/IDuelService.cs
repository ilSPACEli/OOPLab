using MagicWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Services.Interfaces
{
    public interface IDuelService
    {
        void RunDuel(int wizard1Id, int wizard2Id, DuelType type);
        void PrintHistory();
    }
}
