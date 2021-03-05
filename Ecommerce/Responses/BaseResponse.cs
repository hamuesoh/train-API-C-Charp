using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Responses
{
    public class BaseResponseModel
    {
        public int Result { get; set; }
        public object Detail { get; set; }
        public string Message { get; set; }
        public bool Token { get; set; }
        public int LoginProvider { get; set; }
    }

    public class BaseResponse
    {
        public BaseResponseModel Success(object detail, string message = "Success")
        {
            return new BaseResponseModel()
            {
                Result = 1,
                Detail = detail,
                Message = message,
                Token = true,
                LoginProvider = 1
                
            };
        }
    }
}
