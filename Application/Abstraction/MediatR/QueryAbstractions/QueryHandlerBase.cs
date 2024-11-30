using Domain.Results.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.MediatR.QueryAbstractions
{
    public abstract class QueryHandlerBase<TQuery> : IRequestHandler<TQuery, BaseResponse> where TQuery : QueryBase
    {
        public abstract Task<BaseResponse> Handle(TQuery request, CancellationToken cancellationToken);
       
    }
}
