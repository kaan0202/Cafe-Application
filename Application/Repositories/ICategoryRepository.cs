using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ICategoryRepository
    {
        Task<int> AddCategoryAsync(Category category);
        Task<Category> UpdateCategoryAsync(Category category);
        Task<Category> GetCategoryByIdAsync(int id);
        Task<List<Category>> GetAllCategoryAsync();

     }
}
