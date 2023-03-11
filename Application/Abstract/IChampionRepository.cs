using Domain.Champion;

namespace Application.Abstract
{
    public interface IChampionRepository
    {
        Task<Champion> GetById(int id);
        Task Add(Champion champion);
        void Remove(Champion champion);
        Task Update(Champion champion);
    }
}
