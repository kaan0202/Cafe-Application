using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IOfferRepository
    {
        Task<int> AddOfferAsync(Offer offer);
        Task<Offer> UpdateOfferAsync(Offer offer);

        Task<List<Offer>> GetAllOffersAsync();
        Task<Offer> GetOfferByIdAsync(int id);
    }
}
