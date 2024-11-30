using Domain.Results.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.MediatR.CommandAbstractions
{
    public abstract class CommandHandlerBase<TCommand> : IRequestHandler<TCommand, BaseResponse> where TCommand : CommandBase
    {
        public abstract Task<BaseResponse> Handle(TCommand request, CancellationToken cancellationToken);
        
    }
}
