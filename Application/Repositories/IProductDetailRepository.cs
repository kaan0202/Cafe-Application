using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IProductDetailRepository
    {
        Task<ProductDetail> GetProductDetailById(int id);
        Task<int> AddDetailAsync(ProductDetail productDetail);
        Task DeleteDetailAsync(int id);
        Task<ProductDetail> UpdateDetailAsync(ProductDetail productDetail);

    }
}
