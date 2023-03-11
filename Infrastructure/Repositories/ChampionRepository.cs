using Application.Abstract;
using Domain.Champion;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ChampionRepository : IChampionRepository
    {
        private readonly DataContext _context;
        public ChampionRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Champion champion)
        {
            await _context.Champions.AddAsync(champion);
        }

        public async Task<Champion> GetById(int id)
        {
            return await _context.Champions.FirstAsync(c => c.Id == id);
        }

        public async void Remove(Champion champion)
        {
            _context.Champions.Remove(champion);
        }

        public async Task Update(Champion champion)
        {
            _context.Champions.Update(champion);
        }

        
    }
}
