using aural_lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aural_api_user.Models
{
    public class BaseModel
    {
    public ApiCodeModel ApiErrorCode { get; set; }
    public DateTime CurrentDateTime
        {
            get { return DateTime.Now; }
        }

    }
}
