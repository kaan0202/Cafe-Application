using Domain.Results.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Results
{
    public class ErrorResponse : BaseResponse
    {
        public ErrorResponse(string message) : base(message, false)
        {
        }

        public ErrorResponse():base(false)
        {
            
        }
    }
}
