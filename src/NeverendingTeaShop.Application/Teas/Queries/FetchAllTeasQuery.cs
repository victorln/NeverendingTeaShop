using NeverendingTeaShop.Application.Interfaces.Queries;
using NeverendingTeaShop.Application.Interfaces.Repositories;
using NeverendingTeaShop.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeverendingTeaShop.Application.Teas.Queries
{
    public class FetchAllTeasQuery<T> : IFetchAllTeasQuery<T>
    {
        private readonly ITeaRepository _teaRepository;

        public FetchAllTeasQuery(ITeaRepository teaRepository)
        {
            _teaRepository = teaRepository;
        }

        public async Task<T> Execute(IFetchAllTeasOutcomes<T> outcomeHandler)
        {
            return outcomeHandler.GotTeas(new List<Tea>());
        }
    }
}