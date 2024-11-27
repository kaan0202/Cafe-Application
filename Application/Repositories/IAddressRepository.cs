using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IAddressRepository
    {
        Task<int> AddAddressAsync(Address address);
        Task<Address> UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(int id);
        Task<List<Address>> GetAllAddressesAsync();
        Task<Address> GetAddressById(int id);   

    }
}
