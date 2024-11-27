using Application.Core;
using Application.DTOs.User;
using Domain.Results.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services.App
{
    public interface IUserService:IInjectable
    {
        public Task<BaseResponse> CreateUser(CreateUserDto createUserDto);
        public Task<BaseResponse> UpdateUser(UpdateUserDto updateUserDto);
        public Task<BaseResponse> DeleteUser(int id);
    }
}
