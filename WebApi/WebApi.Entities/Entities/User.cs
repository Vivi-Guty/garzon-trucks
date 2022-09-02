using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public partial class User
    {
        [DataMember]
        public string? Token { get; set; }

        [DataMember]
        public IList<UserRole> Roles { get; set; } = new List<UserRole>();
    }
}
