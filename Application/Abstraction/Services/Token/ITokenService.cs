using Application.Core;
using Application.DTOs.Token;
using Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services.Token
{
    public interface ITokenService:IInjectable
    {
        TokenDto CreateToken(AppUser appUser);

    }
}
