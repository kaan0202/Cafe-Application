﻿
using Application.DTOs.Token;
using Application.UnitOfWork.Core;
using Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Handlers
{
    public interface ITokenHandler:IInjectable
    {
        public TokenDto CreateToken(int minutes,AppUser appUser);
        public string CreateRefreshToken();
        public IEnumerable<Claim> GetClaims(AppUser user);

    }
}
