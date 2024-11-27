using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ISizeRepository
    {
        Task<int> AddSizeAsync(Domain.Entities.App.Size size);
        Task<Domain.Entities.App.Size> UpdateSizeAsync(Domain.Entities.App.Size size);
        Task DeleteSizeAsync(int sizeId);
        Task<Domain.Entities.App.Size> GetSizeByIdAsync(int sizeId);
        Task<List<Domain.Entities.App.Size>> GetAllSizeAsync();

    }
}
