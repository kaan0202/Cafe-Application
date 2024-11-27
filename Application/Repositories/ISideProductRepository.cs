using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ISideProductRepository
    {
        Task<int> AddSideProductAsync(SideProduct sideProduct);
        Task<SideProduct> UpdateSideProductAsync(SideProduct sideProduct);
        Task DeleteSideProductAsync(int id);
        Task<List<SideProduct>> GetAllSideProductsAsync();
        Task<SideProduct> GetSideProductById(int id);
    }
}
