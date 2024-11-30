using Application.DTOs.Authorization;
using Application.DTOs.Token;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services.Auth
{
    public interface IAuthorizationService:IInjectable
    {
        public Task<TokenDto> LoginAsync(LoginDto loginDto);
        public Task<TokenDto> RefreshTokenLoginAsync(string refreshToken);
    }
}
