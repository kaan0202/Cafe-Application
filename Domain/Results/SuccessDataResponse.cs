using Domain.Results.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Results
{
    public class SuccessDataResponseT<T> : BaseDataResponse<T> where T : class, new()
    {
        public SuccessDataResponseT(T data, string message) : base(data, message, true)
        {
        }

        public SuccessDataResponseT(T data):base(data,true)
        {
            
        }
    }
}
