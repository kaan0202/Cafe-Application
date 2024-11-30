﻿using Domain.Results.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.MediatR.CommandAbstractions
{
    public abstract class CommandBase : IRequest<BaseResponse>,IMediatrAbstractionCore
    {
    }
}
