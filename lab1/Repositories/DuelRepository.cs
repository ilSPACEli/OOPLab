using MagicWorld.Repositories.Interfaces;
using MagicWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWorld.Repositories
{
    public class DuelRepository : IRepository<DuelHistory>
    {
        private readonly HogwartsDbContext _context;

        public DuelRepository(HogwartsDbContext context) => _context = context;

        public IEnumerable<DuelHistory> GetAll() => _context.DuelHistories;

        public DuelHistory GetById(int id) => null;

        public void Add(DuelHistory entity)
        {
            entity.Id = _context.DuelHistories.Count + 1;
            _context.DuelHistories.Add(entity);
        }
    }
}
