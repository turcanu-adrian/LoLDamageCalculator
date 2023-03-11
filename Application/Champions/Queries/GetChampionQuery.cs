using Application.Abstract;
using Domain.Champion;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Champions.Queries
{
    public class GetChampionQuery : IRequest<Champion>
    {
        public int ChampionId { get; set; }
    }

    public class GetChampionQueryHandler : IRequestHandler<GetChampionQuery, Champion>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetChampionQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Champion> Handle(GetChampionQuery query, CancellationToken cancellationToken)
        {
            Champion champion = await _unitOfWork.ChampionRepository.GetById(query.ChampionId);
            return champion;
        }
    }
}
