using Application.Abstract;
using Domain;
using Domain.Champion;
using MediatR;

namespace Application.Champions.Commands
{
    public class AddChampionCommand : IRequest<bool>
    {
        public Champion Champion { get; set; }
    }

    public class AddChampionCommandHandler : IRequestHandler<AddChampionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddChampionCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(AddChampionCommand command, CancellationToken cancellationToken)
        {
            await _unitOfWork.ChampionRepository.Add(command.Champion);
            await _unitOfWork.Save();

            return true;
        }
    }
}
