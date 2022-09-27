using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    [DataContract]
    public class Login
    {
        [DataMember]
        public string? Domain { get; set; }

        [DataMember]
        public string? UserName { get; set; }
        [DataMember]
        public string? LoginName { get; set; }

        [DataMember]
        public string? Password { get; set; }
    }
}
