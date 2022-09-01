using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public enum UnauthorizedReason
    {
        None = 0,
        Unautenticated = 1,
        NoAppUser = 2,
        AccessDenied = 3
    }
}
