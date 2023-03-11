using Application.Abstract;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext, IChampionRepository championRepository)
        {
            _dataContext = dataContext;
            ChampionRepository = championRepository;
        }

        public IChampionRepository ChampionRepository { get; private set; }

        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose(); 
        }
    }
}
