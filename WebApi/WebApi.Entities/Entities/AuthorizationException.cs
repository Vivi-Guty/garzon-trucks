using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class AuthorizationException : Exception
    {
        public readonly UnauthorizedReason Reason;
        public AuthorizationException(UnauthorizedReason reason) : base()
        {
            this.Reason = reason;
        }
    }
}
