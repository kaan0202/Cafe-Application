using Domain.Results.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Results
{
    public class SuccessResponse : BaseResponse
    {
        public SuccessResponse(string message) : base(message,true)
        {
        }

        public SuccessResponse():base(true)
        {
            
        }
    }
}
